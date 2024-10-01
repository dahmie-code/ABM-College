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
    public partial class Form2 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=AUGUST2024; User Id=sa; Password=password123;";

        public Form2()
        {
            InitializeComponent();
            LoadCategoriesAndItems();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "Create";
        }

        private void createTableBtn_Click(object sender, EventArgs e)
        {
            CreateTable();

        }

        private void CreateTable()
        {
            //Query to create the Categories table
            string categoriesTableQuery = @"
            CREATE TABLE Categories (
                CategoriesId BIGINT IDENTITY(1,1) PRIMARY KEY,
                CategoriesName NVARCHAR(100) NOT NULL
            );";

            // Query to create the Items table
            string itemsTableQuery = @"
            CREATE TABLE Items (
                ItemId BIGINT IDENTITY(1,1) PRIMARY KEY,
                ItemName NVARCHAR(100) NOT NULL,
                ItemPrice DECIMAL(10, 2) NOT NULL,
                ItemQuantity DECIMAL(10, 2)  NOT NULL,
                CategoryId BIGINT NOT NULL,
                FOREIGN KEY (CategoryId) REFERENCES Categories(CategoriesId)
            );";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    SqlCommand createCategoriesCommand = new SqlCommand(categoriesTableQuery, connection);
                    createCategoriesCommand.ExecuteNonQuery();


                    SqlCommand createItemsCommand = new SqlCommand(itemsTableQuery, connection);
                    createItemsCommand.ExecuteNonQuery();

                    MessageBox.Show("Tables 'Categories' and 'Items' created successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadCategoriesAndItems()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT C.CategoriesId, C.CategoriesName, I.ItemName
                    FROM Categories C
                    LEFT JOIN Items I ON C.CategoriesId = I.CategoryId
                    ORDER BY C.CategoriesName, I.ItemName";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    TreeNode currentCategoryNode = null;
                    int currentCategoryId = -1;

                    while (reader.Read())
                    {
                        long categoryIdLong = (long)reader["CategoriesId"];
                        int categoryId = (int)categoryIdLong;
                        string categoryName = reader["CategoriesName"].ToString();
                        string itemName = reader["ItemName"].ToString();


                        if (categoryId != currentCategoryId)
                        {
                            currentCategoryNode = new TreeNode(categoryName);
                            treeView1.Nodes.Add(currentCategoryNode);
                            currentCategoryId = categoryId;
                        }

                        if (!string.IsNullOrEmpty(itemName) && currentCategoryNode != null)
                        {
                            currentCategoryNode.Nodes.Add(new TreeNode(itemName));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading categories and items: " + ex.Message);
                }
            }
        }

    }
}
