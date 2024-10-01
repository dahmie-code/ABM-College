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

namespace WebPage
{
    public partial class Form2 : Form
    {
        private DataGridView homeDataGridView;
        private DataGridView careerDataGridView;
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=AUGUST2024; User Id =sa; Password=password123;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Home";
            tabPage2.Text = "About Us";
            tabPage3.Text = "Career";
            tabPage4.Text = "FAQ";
            tabPage5.Text = "Contact Us";

            homeDataGridView = new DataGridView
            {
                Dock = DockStyle.Fill
            };
            tabControl1.TabPages[0].Controls.Add(homeDataGridView);


            careerDataGridView = new DataGridView
            {
                Dock = DockStyle.Fill
            };
            tabControl1.TabPages[2].Controls.Add(careerDataGridView);


            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.ItemSize = new Size(163, 40);
            tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[0])
            {
                LoadDataIntoGrid("SELECT CategoriesName FROM Categories", homeDataGridView);
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages[2])
            {
                LoadDataIntoGrid("SELECT ItemName, ItemPrice FROM Items", careerDataGridView);
            }
        }
        private void LoadDataIntoGrid(string query, DataGridView gridView)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();


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
