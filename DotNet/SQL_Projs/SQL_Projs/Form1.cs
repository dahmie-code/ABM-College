using System.Data.SqlClient;

namespace SQL_Projs
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest; User Id=sa; Password=password123;";
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            CreateTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            create.Text = "Create";
            deleteBtn.Text = "Delete";
        }
        private void CreateTable()
        {
            string name = nameTextBox.Text.Trim();
            int age = int.Parse(ageTextBox.Text.Trim());
            string email = emailTextBox.Text.Trim();
            DateTime dob = dobDatePicker.Value;

            //            string createTableQuery = @"
            //        CREATE TABLE StudentTable (
            //            StudentId BIGINT IDENTITY(1,1) PRIMARY KEY,
            //            StudentName NVARCHAR(100),
            //            Age INT,
            //            StudentEmail NVARCHAR(100),
            //CreatedAt DATETIME DEFAULT GETDATE()
            //        );";
            //        string constraintQuery = @"
            //    ALTER TABLE StudentTable
            //    ADD CONSTRAINT CHK_Age_LessThanOrEqualTo20
            //    CHECK (Age <= 20);
            //";
            string insertQuery = @"
            INSERT INTO StudentTable (StudentName, Age, StudentEmail, CreatedAt)
            VALUES (@StudentName, @Age, @StudentEmail, @CreatedAt);
            SELECT SCOPE_IDENTITY();";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(insertQuery, connection);

                    command.Parameters.AddWithValue("@StudentName", name);
                    command.Parameters.AddWithValue("@Age", age);
                    command.Parameters.AddWithValue("@StudentEmail", email);
                    command.Parameters.AddWithValue("@CreatedAt", dob);
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Check constraint added to 'StudentTable' successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string tableName = "StudentTable";
            string deleteAllRowsQuery = $"Truncate Table {tableName};";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(deleteAllRowsQuery, connection);

                    connection.Open();

                
                    command.ExecuteNonQuery();

                    MessageBox.Show($"Table '{tableName}' has been deleted successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}