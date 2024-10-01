using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_WindowsApp
{
    public partial class Form1 : Form
    {
        //Connection String
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest;User Id =sa; Password=password123;";
        private bool isColored = false;
        private Color[,] cellColors;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            //SQL query to select the country data

            //string query = "SELECT Id, CountryName FROM tblCountries";
            //string query2 = "SELECT ID, [First Name], [Last Name], Age, Gender, [On Call] FROM tblTest";

            //Create a new DataTable to hold the data
            //DataTable dataTable = new DataTable();



            //Use SqlConnection and SqlDataAdapter to fill the DataTable
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //        adapter.Fill(dataTable);

            //        //Set the DataSource of the ComboBox
            //        comboBox1.DataSource = dataTable;

            //        //Define what is displayed in the ComboBox and what is used as the value
            //        comboBox1.DisplayMember = "CountryName";
            //        comboBox1.ValueMember = "Id";
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //    }
            //}

            LoadData();
            btnSearch.Text = "Search";
            changeBGColor.Text = "Change Color"; 
            Button btnToggleColor = new Button
            {
                Text = "Toggle Colors",
                Location = new Point(150, 20)
            };
            btnToggleColor.Click += changeBGColor_Click;
            this.Controls.Add(btnToggleColor);
        }
        private void LoadData(string searchTerm = "", string sortOrder = "ASC")
        {
            string firstName = txtFirstName?.Text.Trim();
            string lastName = txtLastName?.Text.Trim();
            string age = txtAge?.Text.Trim();
            string gender = txtGender?.Text.Trim();

            string query = "SELECT ID, [First Name], [Last Name], Age, Gender, [On Call], DecimalValue FROM tblTest WHERE 1=1";

            if (!string.IsNullOrEmpty(firstName))
            {
                query += " AND [First Name] LIKE @firstName";
            }
            if (!string.IsNullOrEmpty(lastName))
            {
                query += " AND [Last Name] LIKE @lastName";
            }
            if (!string.IsNullOrEmpty(age))
            {
                query += " AND Age LIKE @age";
            }
            if (!string.IsNullOrEmpty(gender))
            {
                query += " AND Gender LIKE @gender";
            }



            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);



                    if (!string.IsNullOrEmpty(firstName))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@firstName", "%" + firstName + "%");
                    }
                    if (!string.IsNullOrEmpty(lastName))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@lastName", "%" + lastName + "%");
                    }
                    if (!string.IsNullOrEmpty(age))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@age", "%" + age + "%");
                    }
                    if (!string.IsNullOrEmpty(gender))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@gender", "%" + gender + "%");
                    }

                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["First Name"].Visible = true;
                    dataGridView1.Columns["Last Name"].Visible = true;
                    dataGridView1.Columns["Age"].Visible = true;
                    dataGridView1.Columns["Gender"].Visible = true;
                    dataGridView1.Columns["On Call"].Visible = true;
                    dataGridView1.Columns["DecimalValue"].Visible = true;
                    dataGridView1.Columns["DecimalValue"].DefaultCellStyle.NullValue = "";
                    dataGridView1.Columns["DecimalValue"].SortMode = DataGridViewColumnSortMode.Automatic;

                    if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(age) && string.IsNullOrEmpty(gender))
                    {
                        dataGridView1.Columns["Last Name"].Visible = false;
                        dataGridView1.Columns["Age"].Visible = false;
                        dataGridView1.Columns["Gender"].Visible = false;
                        dataGridView1.Columns["On Call"].Visible = false;
                        dataGridView1.Columns["DecimalValue"].Visible = false;
                    }
                    else if (!string.IsNullOrEmpty(lastName) && string.IsNullOrEmpty(age) && string.IsNullOrEmpty(gender))
                    {
                        dataGridView1.Columns["Age"].Visible = false;
                        dataGridView1.Columns["Gender"].Visible = false;
                        dataGridView1.Columns["On Call"].Visible = false;
                        dataGridView1.Columns["DecimalValue"].Visible = false;
                    }
                    else if (!string.IsNullOrEmpty(age) && string.IsNullOrEmpty(gender))
                    {
                        dataGridView1.Columns["Gender"].Visible = false;
                        dataGridView1.Columns["On Call"].Visible = false;
                        dataGridView1.Columns["DecimalValue"].Visible = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (isColored)
            {
    
                Random rnd = new Random();
                e.CellStyle.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
            else
            {
            
                e.CellStyle.BackColor = Color.White;
            }
        }

        private void changeBGColor_Click(object sender, EventArgs e)
        {
         
            isColored = !isColored;

 
            dataGridView1.Refresh();
        }
    }
}