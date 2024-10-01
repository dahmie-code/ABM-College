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

namespace SQL_Projs
{
    public partial class Form3 : Form
    {
        private DataGridView gridView;
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=AUGUST2024; User Id=sa; Password=password123;";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            createBtn.Text = "Create";
            gridView = new DataGridView
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(gridView);

            LoadDataIntoGrid();


        }
        private void CreateTable()
        {
            string query = @"
            CREATE TABLE Plans (
                PlanId BIGINT IDENTITY(1,1) PRIMARY KEY,
                PlanNumber INT NOT NULL,
                PlanPrice  INT NOT NULL, 
            );";


            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand createCategoriesCommand = new SqlCommand(query, connection);
                    createCategoriesCommand.ExecuteNonQuery();


                    SqlCommand createItemsCommand = new SqlCommand(query, connection);
                    createItemsCommand.ExecuteNonQuery();

                    MessageBox.Show("Table 'PlanNum' created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreateTable();
        }
        private void LoadDataIntoGrid()
        {
            try
            {
             
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();

 
                    string query = @"
                        SELECT 
                            PlanNumber,
                            SUM(PlanPrice) AS TotalPlanPrice
                        FROM 
                            Plans
                        GROUP BY 
                            PlanNumber
                        ORDER BY TotalPlanPrice DESC;";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    gridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        
    }
    }
}
