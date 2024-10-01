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
    public partial class FormAddProperty : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";
        public FormAddProperty()
        {
            InitializeComponent();
        }

        private void FormAddProperty_Load(object sender, EventArgs e)
        {
            address.Text = "Address";
            city.Text = "City";
            state.Text = "State";
            zipCode.Text = "Zip Code";
            price.Text = "Price";
            typeLabel.Text = "Type";
            Bedrooms.Text = "No of Bedrooms";
            Bathrooms.Text = "No of Bathrooms";
            desc.Text = "Description";
            saveBtn.Text = "Save";
            cancelBtn.Text = "Cancel";


            cmbPropertyType.Items.Add("Residential");
            cmbPropertyType.Items.Add("Commercial");
            cmbPropertyType.Items.Add("Industrial");
            cmbPropertyType.SelectedIndex = 0;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Properties (Address, City, State, ZipCode, Price, Type, Bedrooms, Bathrooms, Description) VALUES (@Address, @City, @State, @ZipCode, @Price, @Type, @Bedrooms, @Bathrooms, @Description)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@State", txtState.Text);
                cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text));
                cmd.Parameters.AddWithValue("@Type", cmbPropertyType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Bedrooms", Convert.ToInt32(txtBedrooms.Text));
                cmd.Parameters.AddWithValue("@Bathrooms", Convert.ToInt32(txtBathrooms.Text));
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);

                conn.Open();
                cmd.ExecuteNonQuery();

            }
                MessageBox.Show("Property added successfully");
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
