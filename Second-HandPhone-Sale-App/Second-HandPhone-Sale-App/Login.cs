using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Second_HandPhone_Sale_App
{
    public partial class Login : Form
    {
        private string firstName;
        Dictionary<int, string[]> data = new Dictionary<int, string[]>();
        private int currentUserId = 1;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            groupBoxLogin.Text = "Login";
            groupBoxSignUp.Text = "Sign Up";
            signUp.Text = "SIGN UP";
            fName.Text = "First Name";
            lName.Text = "Last Name";
            userName.Text = "Username/E-mail";
            password.Text = "Password";
            confirmPassword.Text = "Confirm Password";
            signUpButton.Text = "Sign Up";
            message.Text = "";

            signIn.Text = "SIGN IN";
            usernameLogin.Text = "Username/E-mail";
            passwordLogin.Text = "Password";
            loginButton.Text = "Login";
            signInMessage.Text = "";
            forgotPassword.Text = "Forgot Password";
            forgotPassword.AutoSize = false;
            forgotPassword.Width = 150;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text.Trim();
            string userPassword = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(userPassword))
            {
                signInMessage.Text = "Please enter your username and password.";
                signInMessage.ForeColor = Color.Red;
                return;
            }

            var userEntry = data.FirstOrDefault(d => d.Value[2] == user && d.Value[3] == userPassword);

            if (userEntry.Key != 0)
            {
                signInMessage.Text = "User successfully logged in";
                signInMessage.ForeColor = Color.Green;

                string firstName = userEntry.Value[0];
                string userContact = userEntry.Value.Length > 4 ? userEntry.Value[4] : "";

                Home homeForm = new Home(firstName, data, userEntry.Key, userContact);
                homeForm.ShowDialog();
            }
            else
            {
                signInMessage.Text = "The credentials are not correct";
                signInMessage.ForeColor = Color.Red;
            }

            usernameTextBox.Clear();
            passwordTextBox.Clear();
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            string userName = userTextBox.Text.Trim();
            string fName = fNametextBox.Text.Trim();
            string lName = lNametextBox.Text.Trim();
            string password = psdTextBox.Text;
            string confirmPassword = confirmTextBox.Text;

            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                message.Text = "All fields are required.";
                message.ForeColor = Color.Red;
                return;
            }

            if (!IsValidEmail(userName))
            {
                message.Text = "Please enter a valid email address.";
                message.ForeColor = Color.Red;
                return;
            }

            if (password != confirmPassword)
            {
                message.Text = "Password and confirm password do not match.";
                message.ForeColor = Color.Red;
                return;
            }

            if (password.Length < 6)
            {
                message.Text = "Password must be at least 6 characters long.";
                message.ForeColor = Color.Red;
                return;
            }

            if (data.Values.Any(user => user[2] == userName))
            {
                message.Text = "Username already exists. Please choose a different username.";
                message.ForeColor = Color.Red;
                return;
            }

            data.Add(currentUserId, new string[] { fName, lName, userName, password });
            message.Text = "User signed up successfully!";
            message.ForeColor = Color.Green;
            currentUserId++;

            userTextBox.Clear();
            fNametextBox.Clear();
            lNametextBox.Clear();
            psdTextBox.Clear();
            confirmTextBox.Clear();
        }

        private void forgotPassword_Click(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text.Trim();
            var userEntry = data.FirstOrDefault(d => d.Value[2] == user);

            if (userEntry.Key != 0)
            {
                Form2 f2 = new Form2(data, userEntry.Key);
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username not found. Please enter a valid username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }


}
