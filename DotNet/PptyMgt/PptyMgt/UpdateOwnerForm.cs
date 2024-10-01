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
    public partial class UpdateOwnerForm : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";
        public int OwnerID { get; set; }
        public UpdateOwnerForm(int ownerID)
        {
            InitializeComponent();
            OwnerID = ownerID;
            LoadOwnerDetails();
        }

        private void UpdateOwnerForm_Load(object sender, EventArgs e)
        {
            LoadLabelsandButtons();
        }
        private void LoadLabelsandButtons(){
            firstNameLabel.Text = "First Name";
            lastnameLabel.Text = "Last Name";
            phoneNumberLabel.Text = "Phone Number";
            addressLabel.Text = "Address";
            emailLabel.Text = "Email Address";
            saveBtn.Text = "Save";
            cancelBtn.Text = "Cancel";  
            }
        private void LoadOwnerDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Owners WHERE OwnerID = @OwnerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@OwnerID", OwnerID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        firstName.Text = reader["FirstName"].ToString();
                        lastName.Text = reader["LastName"].ToString();
                        phoneNumber.Text = reader["PhoneNumber"].ToString();
                        email.Text = reader["Email"].ToString();
                        addrs.Text = reader["Address"].ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Owners SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address WHERE OwnerID = @OwnerID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", firstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastName.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);
                    cmd.Parameters.AddWithValue("@Email", email.Text);                    
                    cmd.Parameters.AddWithValue("@Address", addrs.Text);
                    cmd.Parameters.AddWithValue("@OwnerID", OwnerID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("owner updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message);
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
