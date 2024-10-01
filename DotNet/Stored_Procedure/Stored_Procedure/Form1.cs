using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Stored_Procedure
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest; User Id =sa; Password=password123;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPersonData();
        }

        private void LoadPersonData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string storedProc = "proc_InsertData";
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(storedProc, conn);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string genderColor = row.Cells["GenderColor"].Value?.ToString();
                        if (genderColor == "Yellow")
                        {
                            row.Cells["Gender"].Style.BackColor = Color.Yellow;
                        }
                        else if (genderColor == "Blue")
                        {
                            row.Cells["Gender"].Style.BackColor = Color.Blue;
                        }
                        else
                        {
                            row.Cells["Gender"].Style.BackColor = Color.Pink;
                        }

                        string ageColor = row.Cells["AgeColor"].Value?.ToString();
                        if (ageColor == "Green")
                        {
                            row.Cells["Age"].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            row.Cells["Age"].Style.BackColor = Color.Gray;
                        }

                        string emailValidity = row.Cells["EmailValidity"].Value?.ToString();
                        if (emailValidity == "Invalid")
                        {
                            row.Cells["EmailId"].Style.BackColor = Color.Red;
                        }
                        dataGridView1.Columns["EmailValidity"].Visible = false;
                        dataGridView1.Columns["AgeColor"].Visible = false;
                        dataGridView1.Columns["GenderColor"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}