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

namespace PptyMgt
{


    public partial class PropertyManagement : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";
        public PropertyManagement()
        {
            InitializeComponent();
        }

        private void PropertyManagement_Load(object sender, EventArgs e)
        {
            LoadProperties();
            LoadLabelsandButtons();

        }
        private void LoadLabelsandButtons()
        {
            btnAdd.Text = "Add Property";
            updateBtn.Text = "Update Property";
            deleteBtn.Text = "Delete";
            btnFilter.Text = "Filter";
            minPriceLabel.Text = "Min Price:";
            maxPriceLabel.Text = "Max Price";
            typeLabel.Text = "Type";
            cityLabel.Text = "City";
            stateLabel.Text = "State";
        }
        private void LoadProperties(string filterQuery = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Properties";

                    if (!string.IsNullOrEmpty(filterQuery))
                    {
                        query += " WHERE " + filterQuery;
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormAddProperty addPropertyForm = new FormAddProperty())
                {
                    if (addPropertyForm.ShowDialog() == DialogResult.OK)
                    {

                        LoadProperties();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int propertyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PropertyID"].Value);

                using (FormUpdateProperty updatePropertyForm = new FormUpdateProperty(propertyID))
                {
                    if (updatePropertyForm.ShowDialog() == DialogResult.OK)
                    {

                        LoadProperties();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a property to update.");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count > 0)
                {

                    int propertyID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PropertyID"].Value);

                    var confirmResult = MessageBox.Show("Are you sure you want to delete this property?",
                                                         "Confirm Delete",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM Properties WHERE PropertyID = @PropertyID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@PropertyID", propertyID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                        LoadProperties();
                        MessageBox.Show("Property deleted successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a property to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(txtMinPrice.Text))
                {
                    filters.Add($"Price >= @MinPrice");
                }

                if (!string.IsNullOrEmpty(txtMaxPrice.Text))
                {
                    filters.Add($"Price <= @MaxPrice");
                }

                if (!string.IsNullOrEmpty(txtType.Text))
                {
                    filters.Add($"Type LIKE @Type");
                }

                if (!string.IsNullOrEmpty(txtCity.Text))
                {
                    filters.Add($"City LIKE @City");
                }

                if (!string.IsNullOrEmpty(txtState.Text))
                {
                    filters.Add($"State LIKE @State");
                }

                string filterQuery = string.Join(" AND ", filters);
                LoadProperties(filterQuery);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
