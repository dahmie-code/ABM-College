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

namespace E_commerce_Tool
{
    public partial class Form2 : Form
    {
        private Dictionary<int, string[]> data;
        private int userId;
        public Form2(Dictionary<int, string[]> userData, int id)
        {
            InitializeComponent();
            data = userData;
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
            string newPassword = newPasswordTextB.Text;
            string confirmPassword = confirmPasswordTextB.Text;

            if (newPassword == confirmPassword && !string.IsNullOrEmpty(newPassword))
            {
                if (data.ContainsKey(userId))
                {
                    data[userId][3] = newPassword;
                    MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match or are empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
