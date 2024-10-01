using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second_HandPhone_Sale_App
{
    public partial class Home : Form
    {
        private string user;

        private string currentUsername;
        private Dictionary<int, string[]> data;
        private int userId;
        private string userContact;
        public Home(string username, Dictionary<int, string[]> data, int userId, string userContact)
        {
            InitializeComponent();
            currentUsername = username;
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.userId = userId;
            this.userContact = userContact;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = $"Welcome {currentUsername}";
            logOutButton.Text = "Log Out";
            logOutButton.BackColor = Color.Red;
            usedNewlabel.Text = "Used as New Phones";
            usedGoodlabel.Text = "Used in Good Condition Phones";
            fairlyUsedLabel.Text = "Fairly Used Phones";
            

        }

        private void buyPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("User data is not available. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userId <= 0)
            {
                MessageBox.Show("Invalid user ID. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Buy buyForm = new Buy(data, userId, userContact);
            buyForm.ShowDialog();
        }

        private void sellPhonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data == null || string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("User data or username is not available. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sell sellForm = new Sell(currentUsername, data, userId);
            sellForm.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.ShowDialog();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("User data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserProfileForm profileForm = new UserProfileForm(data, userId);
            profileForm.ShowDialog();
        }
    }
}
