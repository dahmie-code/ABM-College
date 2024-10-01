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
    public partial class Sell : Form
    {
        private string userContact;
        private Dictionary<int, string[]> data;
        private int userId;
        public Sell(string userContact, Dictionary<int, string[]> data, int userId)
        {
            InitializeComponent();
            this.userContact = userContact;
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.userId = userId;
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            conditionComboBox.Items.AddRange(new string[] { "Like New", "Used", "Refurbished" });
            conditionComboBox.SelectedIndex = 0;
            contactTextBox.Text = userContact;
            contactTextBox.ReadOnly = true;
            submitButton.Text = "Submit";
            contactLabel.Text = "Contact";
            modelLabel.Text = "Phone Model";
            price.Text = "Price";
            conditionLabel.Text = "Phone Condition";
            descriptionLabel.Text = "Description";
            logOutButton.Text = "Log Out";
            logOutButton.BackColor = Color.Red;
            label1.Text = "LIST PHONE";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string model = modelTextBox.Text.Trim();
            string priceText = priceTextBox.Text.Trim();
            string condition = conditionComboBox.SelectedItem.ToString();
            string description = descriptionTextBox.Text.Trim();


            if (string.IsNullOrEmpty(model) || string.IsNullOrEmpty(priceText) || !decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Please provide valid input for all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Your phone has been listed for sale!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            modelTextBox.Clear();
            priceTextBox.Clear();
            descriptionTextBox.Clear();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userContact, data, userId, userContact);
            homeForm.ShowDialog();
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

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("User data is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserProfileForm profileForm = new UserProfileForm(data, userId);
            profileForm.ShowDialog();
        }

        private void myListingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyListingsForm listingsForm = new MyListingsForm(data, userId, userContact);
            listingsForm.ShowDialog();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.ShowDialog();
        }
    }
}
