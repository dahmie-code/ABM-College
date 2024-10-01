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

namespace MoverPacker
{
    public partial class Form3 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest; User Id = sa; Password=password123;";

        public Form3()
        {
            InitializeComponent();
            LoadFirstUsername();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {

                    var users = new[]
                    {
                        new { Username = "jdoe", FirstName = "John", LastName = "Doe", Age = 30, Gender = "Male" },
                        new { Username = "asmith", FirstName = "Alice", LastName = "Smith", Age = 25, Gender = "Female" },
                        new { Username = "bwilliams", FirstName = "Bob", LastName = "Williams", Age = 28, Gender = "Male" },
                        new { Username = "ckim", FirstName = "Catherine", LastName = "Kim", Age = 32, Gender = "Female" },
                        new { Username = "dlee", FirstName = "David", LastName = "Lee", Age = 40, Gender = "Male" },
                        new { Username = "esanchez", FirstName = "Elena", LastName = "Sanchez", Age = 35, Gender = "Female" },
                        new { Username = "fnguyen", FirstName = "Frank", LastName = "Nguyen", Age = 27, Gender = "Male" },
                        new { Username = "gharris", FirstName = "Grace", LastName = "Harris", Age = 22, Gender = "Female" },
                        new { Username = "hwhite", FirstName = "Henry", LastName = "White", Age = 31, Gender = "Male" },
                        new { Username = "iwilson", FirstName = "Isabella", LastName = "Wilson", Age = 29, Gender = "Female" }
                    };
                    foreach (var user in users)
                    {
                        string commandText = @"
                            DECLARE @Username NVARCHAR(50), @FirstName NVARCHAR(50), @LastName NVARCHAR(50), @Age INT, @Gender NVARCHAR(10);
                            SET @Username = @UsernameParam;
                            SET @FirstName = @FirstNameParam;
                            SET @LastName = @LastNameParam;
                            SET @Age = @AgeParam;
                            SET @Gender = @GenderParam;

                            INSERT INTO Users (Username, FirstName, LastName, Age, Gender) 
                            VALUES (@Username, @FirstName, @LastName, @Age, @Gender);";
                        SqlCommand command = new SqlCommand(commandText, conn, transaction);

                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@FirstName", user.FirstName);
                        command.Parameters.AddWithValue("@LastName", user.LastName);
                        command.Parameters.AddWithValue("@Age", user.Age);
                        command.Parameters.AddWithValue("@Gender", user.Gender);

                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("10 records inserted successfully!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int idToUpdate = 2;
                    string usernameToUpdate = "asmithson";
                    string newFirstName = "Aiya";
                    string newLastName = "Smithson";
                    int newAge = 51;
                    string newGender = "Male";

                    string commandText = @"
                        UPDATE Users 
                        SET FirstName = @FirstName, LastName = @LastName, Age = @Age, Gender = @Gender
                        WHERE UserId = @UserId";

                    SqlCommand command = new SqlCommand(commandText, connection, transaction);

                    command.Parameters.AddWithValue("@UserId", idToUpdate);
                    command.Parameters.AddWithValue("@Username", usernameToUpdate);
                    command.Parameters.AddWithValue("@FirstName", newFirstName);
                    command.Parameters.AddWithValue("@LastName", newLastName);
                    command.Parameters.AddWithValue("@Age", newAge);
                    command.Parameters.AddWithValue("@Gender", newGender);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Record updated successfully!");
                    }
                    else
                    {
                        transaction.Rollback();
                        MessageBox.Show("No record found with the specified Username.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            insertBtn.Text = "Insert";
            updateBtn.Text = "Update";
            deleteBtn.Text = "Delete";
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    int[] idsToDelete = new int[] { 1, 2, 3, 4, 5, 6, 7 };

                    foreach (int id in idsToDelete)
                    {

                        string commandText = "DELETE FROM Users WHERE UserId = @UserId";

                        SqlCommand command = new SqlCommand(commandText, connection, transaction);
                        command.Parameters.AddWithValue("@UserId", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception($"No record found with ID {id}");
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("7 records deleted successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void LoadFirstUsername()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TOP 1 Username FROM Users ORDER BY Username";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        usernameLabel.Text = result.ToString();
                    }
                    else
                    {
                        usernameLabel.Text = "No users found";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
    }
