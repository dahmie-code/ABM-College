using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stored_Procedure
{
    public partial class Form2 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest; User Id =sa; Password=password123;";
        DataTable employeeData;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            PopulateCurrencyFilter();
        }
        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM fn_GetEmployeeDetails()", conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    employeeData = new DataTable();


                    da.Fill(employeeData);


                    dataGridView1.DataSource = employeeData;

                    CalculateTotalAmount("USD");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void PopulateCurrencyFilter()
        {

            if (employeeData == null || employeeData.Rows.Count == 0)
            {
                MessageBox.Show("No employee data available to filter.");
                return;
            }

            var distinctCurrencies = employeeData.AsEnumerable()
                .Select(row => row.Field<string>("EmployeePreferredCurrency"))
                .Distinct()
                .ToList();

            comboBoxCurrencyFilter.Items.AddRange(distinctCurrencies.ToArray());
            comboBoxCurrencyFilter.Items.Insert(0, "All");
            comboBoxCurrencyFilter.SelectedIndex = 0;
        }


        private void comboBoxCurrencyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCurrency = comboBoxCurrencyFilter.SelectedItem.ToString();

            DataTable filteredData;

            if (selectedCurrency == "All")
            {
                filteredData = employeeData.Copy();
            }
            else
            {
                filteredData = employeeData.AsEnumerable()
                    .Where(row => row.Field<string>("EmployeePreferredCurrency") == selectedCurrency)
                    .CopyToDataTable();
            }

     
            if (!filteredData.Columns.Contains("Count"))
            {
                filteredData.Columns.Add("Count", typeof(int));
            }
            if (!filteredData.Columns.Contains("Average"))
            {
                filteredData.Columns.Add("Average", typeof(decimal));
            }


            bool totalRowExists = filteredData.AsEnumerable()
                .Any(row => row.Field<string>("EmployeeName") == "Total");

            if (!totalRowExists)
            {

                var (totalAmount, totalCount, avg) = CalculateTotalAmount(selectedCurrency == "All" ? "All" : selectedCurrency);



                DataRow totalRow = filteredData.NewRow();
                totalRow["EmployeeName"] = "Total";
                totalRow["EmployeePlanAmount"] = totalAmount;
                totalRow["Count"] = totalCount;
                totalRow["Average"] = avg;

                filteredData.Rows.Add(totalRow);
            }

            dataGridView1.DataSource = filteredData;
        }
        private (decimal TotalAmount, int TotalCount, decimal AverageAmount) CalculateTotalAmount(string currency)
        {
            decimal totalAmount = 0;
            int totalCount = 0;
            decimal avg = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (string.IsNullOrWhiteSpace(currency) || currency.Trim().Equals("All", StringComparison.OrdinalIgnoreCase))
                    {
                        query = @"
                    SELECT 
                        SUM(
                            CASE 
                                WHEN EmployeePreferredCurrency = 'USD' THEN ISNULL(EmployeePlanAmount, 0)
                                WHEN EmployeePreferredCurrency = 'CAD' THEN ISNULL(EmployeePlanAmount, 0) / 1.33
                                WHEN EmployeePreferredCurrency = 'EUR' THEN ISNULL(EmployeePlanAmount, 0) * 1.10
                                ELSE 0
                            END
                        ) AS TotalAmount,
                        COUNT(*) AS TotalCount,
                        AVG(
                            CASE 
                                WHEN EmployeePreferredCurrency = 'USD' THEN ISNULL(EmployeePlanAmount, 0)
                                WHEN EmployeePreferredCurrency = 'CAD' THEN ISNULL(EmployeePlanAmount, 0) / 1.33
                                WHEN EmployeePreferredCurrency = 'EUR' THEN ISNULL(EmployeePlanAmount, 0) * 1.10
                                ELSE 0
                            END
                        ) AS AverageAmount
                    FROM fn_GetEmployeeDetails()";
                    }
                    else
                    {
                        query = @"
                    SELECT 
                        SUM(ISNULL(EmployeePlanAmount, 0)) AS TotalAmount,
                        COUNT(*) AS TotalCount,
                        AVG(ISNULL(EmployeePlanAmount, 0)) AS AverageAmount
                    FROM fn_GetEmployeeDetails()
                    WHERE EmployeePreferredCurrency = @Currency";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrWhiteSpace(currency) && !currency.Trim().Equals("All", StringComparison.OrdinalIgnoreCase))
                    {
                        cmd.Parameters.AddWithValue("@Currency", currency);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalAmount = reader.GetDecimal(reader.GetOrdinal("TotalAmount"));
                            totalCount = reader.GetInt32(reader.GetOrdinal("TotalCount"));
                            avg = reader.IsDBNull(reader.GetOrdinal("AverageAmount"))
                                ? 0
                                : reader.GetDecimal(reader.GetOrdinal("AverageAmount"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return (totalAmount, totalCount, avg);
        }




    }
}
