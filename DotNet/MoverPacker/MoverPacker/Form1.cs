using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace MoverPacker
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=AUGUST2024; User Id =sa; Password=password123;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            signIn.Text = "SIGN IN";
            user.Text = "Username/E-mail";
            pass.Text = "Password";
            signInButton.Text = "Login";
            signInMessage.Text = "";
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string user = userText.Text.Trim();
            string userPassword = passText.Text.Trim();
            if (user == "" || userPassword == "")
            {
                signInMessage.Text = "Please enter your username and password.";
                signInMessage.ForeColor = Color.Red;
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT u.FirstName, u.Role, w.Balance FROM Users u JOIN Wallet w ON u.UserID = w.UserID WHERE u.Username = @Username AND u.Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user);
                command.Parameters.AddWithValue("@Password", userPassword);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstName = reader["FirstName"].ToString();
                        string role = reader["Role"].ToString();
                        decimal balance = (decimal)reader["Balance"];

                        signInMessage.Text = "User successfully logged in";
                        signInMessage.ForeColor = Color.Green;

                        Form2 f2 = new Form2(firstName, role, balance);
                        f2.ShowDialog();
                    }
                    else
                    {
                        signInMessage.Text = "The credentials are not correct";
                        signInMessage.ForeColor = Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    signInMessage.Text = "An error occurred: " + ex.Message;
                    signInMessage.ForeColor = Color.Red;
                }
            }

            userText.Clear();
            passText.Clear();

        }
    }

}