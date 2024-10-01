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

namespace PptyMgt
{
    public partial class addOwnerForm : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";
        public addOwnerForm()
        {
            InitializeComponent();
        }

        private void addOwnerForm_Load(object sender, EventArgs e)
        {
            firstNameLabel.Text = "First Name";
            lastnameLabel.Text = "LastName";
            emailLabel.Text = "Email";
            addressLabel.Text = "Address";
            phoneNumberLabel.Text = "Phone Number";
            saveBtn.Text = "Save";
            cancelBtn.Text = "Cancel";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Owners (FirstName, LastName, PhoneNumber, Email, Address) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);
                    cmd.Parameters.AddWithValue("@Address", addrs.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Owner Details added successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
