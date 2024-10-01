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

namespace LoginAndSignUp
{
    public partial class Form2 : Form
    {
        //private Dictionary<int, string[]> data;
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=Auth;User Id =sa; Password=password123;";

        private int userId;
        public Form2( int id)
        {
            InitializeComponent();
            //data = userData;
            userId = id;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

            newPassword.Text = "New Password";
            confirmPassword.Text = "Confirm Password";
            forgotPSubmitButton.Text = "Submit";

        }

        private void forgotPSubmitButton_Click(object sender, EventArgs e)
        {
            string newPassword = newPasswordTextB.Text.Trim();
            string confirmPassword = confirmPasswordTextB.Text.Trim();
            if (newPassword == confirmPassword && !string.IsNullOrEmpty(newPassword))
            {
                UpdatePassword(newPassword);
            }
            else
            {
                MessageBox.Show("Passwords do not match or are empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //if (newPassword == confirmPassword && !string.IsNullOrEmpty(newPassword))
            //{
            //    if(data.ContainsKey(userId)) {
            //        data[userId][3] = newPassword;
            //        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Passwords do not match or are empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    }
            //}
        }
        private void UpdatePassword(string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET Password = @Password WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Password", newPassword);
                command.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error updating password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        }
}
