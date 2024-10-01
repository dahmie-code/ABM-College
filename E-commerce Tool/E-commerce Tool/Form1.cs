using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace E_commerce_Tool
{
    public partial class Form1 : Form
    {
        Dictionary<int, string[]> data = new Dictionary<int, string[]>();
        private int currentUserId = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text;
            string userPassword = passwordTextBox.Text;

            if (user != "" && userPassword != "")
            {
                var userEntry = data.FirstOrDefault(d => d.Value[2] == user && d.Value[3] == userPassword);

                if (userEntry.Key != 0)
                {
                    signInMessage.Text = "User successfully logged in";
                    signInMessage.ForeColor = Color.Green;


                    Form4 f4 = new Form4();
                    f4.ShowDialog();
                }
                else
                {
                    signInMessage.Text = "The credentials are not correct";
                    signInMessage.ForeColor = Color.Red;
                }
            }
            else
            {
                signInMessage.Text = "Please enter your username and password.";
                signInMessage.ForeColor = Color.Red;
            }

            usernameTextBox.Clear();
            passwordTextBox.Clear();

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string userName = userTextBox.Text;
            string fName = fNametextBox.Text;
            string lName = lNametextBox.Text;
            string password = psdTextBox.Text;
            string confirmPassword = confirmTextBox.Text;

            if (password != confirmPassword)
            {

                message.Text = "Password and confirm password doesn't match";
                message.ForeColor = Color.Red;
            }
            else if (userName != "" && password != "" && password == confirmPassword)
            {
                if (!data.Values.Any(user => user[2] == userName))
                {
                    data.Add(currentUserId, new string[] { fName, lName, userName, password });
                    message.Text = "User signed up successfully and your data are stored";
                    message.ForeColor = Color.Green;
                    currentUserId++;
                }
                else
                {
                    message.Text = "Username already exists. Please choose a different username.";
                    message.ForeColor = Color.Red;
                }
            }
            else
            {
                message.Text = "The credentials are invalid";
                message.ForeColor = Color.Red;
            }
            userTextBox.Clear();
            fNametextBox.Clear();
            lNametextBox.Clear();
            psdTextBox.Clear();
            confirmTextBox.Clear();
        }

        private void forgotPassword_Click_1(object sender, EventArgs e)
        {
            string user = usernameTextBox.Text;
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
    }
}