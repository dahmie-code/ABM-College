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
    public partial class Owner_Management : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";

        public Owner_Management()
        {
            InitializeComponent();
        }

        private void Owner_Management_Load(object sender, EventArgs e)
        {
            LoadOwners();
            btnAdd.Text = "Add Owner";
            updateBtn.Text = "Update";
            deleteBtn.Text = "Delete";
        }
        private void LoadOwners(string filterQuery = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Owners";

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
                using (addOwnerForm addOwnerForm = new addOwnerForm())
                {
                    if (addOwnerForm.ShowDialog() == DialogResult.OK)
                    {

                        LoadOwners();

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
                int ownerID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OwnerID"].Value);

                using (UpdateOwnerForm updateOwnerForm = new UpdateOwnerForm(ownerID))
                {
                    if (updateOwnerForm.ShowDialog() == DialogResult.OK)
                    {

                        LoadOwners();
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

                    int ownerID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OWnerID"].Value);

                    var confirmResult = MessageBox.Show("Are you sure you want to delete this owner details?",
                                                         "Confirm Delete",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            string query = "DELETE FROM Owners WHERE OwnerID = @OwnerID";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@OwnerID", ownerID);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                        LoadOwners();
                        MessageBox.Show("Owner Details deleted successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an owner to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

 
    }
}
