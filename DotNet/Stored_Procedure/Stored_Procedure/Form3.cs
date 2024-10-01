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
    public partial class Form3 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest; User Id =sa; Password=password123;";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadGroceryData();
            btnEnd.Text = "EndsWith";
            btnStart.Text = "StartsWith";
            btnContain.Text = "Contains";
            btnSearch.Text = "Any";
        }
        private void LoadGroceryData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM GroceryView", conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);


                    dataGridView1.DataSource = dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SearchGrocery("StartsWithO", textBoxSearch.Text);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            SearchGrocery("EndsWithT", textBoxSearch.Text);
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            SearchGrocery("ContainsEA", textBoxSearch.Text);
        }
        private void SearchGrocery(string groceryDesc, string branchName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("GetGrocery", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@SearchType", searchType);
                    //cmd.Parameters.AddWithValue("@SearchTerm", searchTerm);
                    cmd.Parameters.AddWithValue("@GroceryDesc", groceryDesc);
                    cmd.Parameters.AddWithValue("@BranchName", branchName);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchGrocery(txtGroceryDesc.Text, textBoxSearch.Text);
        }
    }
}
