using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginAndSignUp
{
    public partial class Form1 : Form
    {
        //Dictionary<int, string[]> data = new Dictionary<int, string[]>();
        //private int currentUserId = 1;
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=Auth; bUser Id =sa; Password=password123;";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            signUp.Text = "SIGN UP FORM";
            fName.Text = "First Name";
            lName.Text = "Last Name";
            userName.Text = "Username/E-mail";
            password.Text = "Password";
            confirmPassword.Text = "Confirm Password";
            signUpButton.Text = "Sign Up";
            message.Text = "";

            signIn.Text = "SIGN IN";
            user.Text = "Username/E-mail";
            pass.Text = "Password";
            signInButton.Text = "Login";
            signInMessage.Text = "";
            forgotPassword.Text = "Forgot Password";
            forgotPassword.AutoSize = false;
            forgotPassword.Width = 150;
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string userName = userTextBox.Text.Trim();
            string fName = fNametextBox.Text.Trim();
            string lName = lNametextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            string confirmPassword = confirmTextBox.Text.Trim();

            //if (password != confirmPassword)
            //{

            //    message.Text = "Password and confirm password doesn't match";
            //    message.ForeColor = Color.Red;
            //}
            //else if (userName != "" && password != "" && password == confirmPassword)
            //{
            //    if (!data.Values.Any(user => user[2] == userName))
            //    {
            //        data.Add(currentUserId, new string[] { fName, lName, userName, password });
            //        message.Text = "User signed up successfully and your data are stored";
            //        message.ForeColor = Color.Green;
            //        currentUserId++;
            //    }
            //    else
            //    {
            //        message.Text = "Username already exists. Please choose a different username.";
            //        message.ForeColor = Color.Red;
            //    }
            //}
            //else
            //{
            //    message.Text = "The credentials are invalid";
            //    message.ForeColor = Color.Red;
            //}


            if (password != confirmPassword)
            {
                message.Text = "Password and confirm password don't match";
                message.ForeColor = Color.Red;
                return;
            }

            if (userName == "" || password == "")
            {
                message.Text = "The credentials are invalid";
                message.ForeColor = Color.Red;
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (FirstName, LastName, Username, Password) VALUES (@FirstName, @LastName, @Username, @Password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", fName);
                command.Parameters.AddWithValue("@LastName", lName);
                command.Parameters.AddWithValue("@Username", userName);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    message.Text = "User signed up successfully and your data is stored";
                    message.ForeColor = Color.Green;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        message.Text = "Username already exists. Please choose a different username.";
                    }
                    else
                    {
                        message.Text = "An error occurred: " + ex.Message;
                    }
                    message.ForeColor = Color.Red;
                }
            }

            userTextBox.Clear();
            fNametextBox.Clear();
            lNametextBox.Clear();
            passwordTextBox.Clear();
            confirmTextBox.Clear();


        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string user = userText.Text.Trim();
            string userPassword = passText.Text.Trim();

            //if (user != "" && userPassword != "")
            //{
            //    var userEntry = data.FirstOrDefault(d => d.Value[2] == user && d.Value[3] == userPassword);

            //    if (userEntry.Key != 0)
            //    {
            //        signInMessage.Text = "User successfully logged in";
            //        signInMessage.ForeColor = Color.Green;


            //        Form3 f3 = new Form3(userEntry.Value[0]);
            //        f3.ShowDialog();
            //    }
            //    else
            //    {
            //        signInMessage.Text = "The credentials are not correct";
            //        signInMessage.ForeColor = Color.Red;
            //    }
            //}
            //else
            //{
            //    signInMessage.Text = "Please enter your username and password.";
            //    signInMessage.ForeColor = Color.Red;
            //}
            if (user == "" || userPassword == "")
            {
                signInMessage.Text = "Please enter your username and password.";
                signInMessage.ForeColor = Color.Red;
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT FirstName FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user);
                command.Parameters.AddWithValue("@Password", userPassword);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        signInMessage.Text = "User successfully logged in";
                        signInMessage.ForeColor = Color.Green;

                        Form3 f3 = new Form3(result.ToString());
                        f3.ShowDialog();
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

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            //string user = userText.Text;
            //var userEntry = data.FirstOrDefault(d => d.Value[2] == user);

            //if (userEntry.Key != 0)
            //{
            //    Form2 f2 = new Form2(data, userEntry.Key);
            //    f2.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Username not found. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            string user = userText.Text.Trim();

            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Please enter your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserId FROM Users WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", user);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);
                        Form2 f2 = new Form2(userId);
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username not found. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
