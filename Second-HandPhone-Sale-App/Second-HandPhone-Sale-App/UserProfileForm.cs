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
    public partial class UserProfileForm : Form
    {
        private Dictionary<int, string[]> data;
        private int userId;

        public UserProfileForm(Dictionary<int, string[]> data, int userId)
        {
            InitializeComponent();
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.userId = userId;
            //LoadUserProfile();
        }

        private void LoadUserProfile()
        {
       
            if (data == null)
            {
                throw new InvalidOperationException("Data is not initialized.");
            }

            if (data.ContainsKey(userId))
            {
                var userInfo = data[userId];

                if (userInfo != null && userInfo.Length >= 4)
                {
                    fNameTextBox.Text = userInfo[0];
                    lNameTextBox.Text = userInfo[1];
                    userNameTextBox.Text = userInfo[2];
                    passwordTextBox.Text = userInfo[3];
                }
                else
                {
                    MessageBox.Show("User information is incomplete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void saveButton_Click_1(object sender, EventArgs e)
        {
            if (data.ContainsKey(userId))
            {
                data[userId] = new string[]
                {
                    fNameTextBox.Text.Trim(),
                    lNameTextBox.Text.Trim(),
                    userNameTextBox.Text.Trim(),
                    passwordTextBox.Text.Trim()
                };

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("User not found. Profile cannot be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {
            userProfLabel.Text = "PROFILE";
            fNamelabel.Text = "First Name";
            lNameLabel.Text = "Last Name";
            userNameLabel.Text = "Username";
            passwordLabel.Text = "Password";
            saveButton.Text = "Save";
            LoadUserProfile();
        }
    }
}
