using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PptyMgt
{
    public partial class FormUpdateProperty : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";
        public int PropertyID { get; set; }
        public FormUpdateProperty(int propertyID)
        {
            InitializeComponent();
            PropertyID = propertyID;
            LoadPropertyDetails();
        }

        private void FormUpdateProperty_Load(object sender, EventArgs e)
        {
            LoadPropertyTypes();
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
        }
        private void LoadPropertyTypes()
        {

            cmbPropertyType.Items.Add("Residential");
            cmbPropertyType.Items.Add("Commercial");
            cmbPropertyType.Items.Add("Industrial");
        }
        private void LoadPropertyDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Properties WHERE PropertyID = @PropertyID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PropertyID", PropertyID);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtAddress.Text = reader["Address"].ToString();
                        txtCity.Text = reader["City"].ToString();
                        txtState.Text = reader["State"].ToString();
                        txtZipCode.Text = reader["ZipCode"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        cmbPropertyType.SelectedItem = reader["Type"].ToString();
                        txtBedrooms.Text = reader["Bedrooms"].ToString();
                        txtBathrooms.Text = reader["Bathrooms"].ToString();
                        txtDescription.Text = reader["Description"].ToString();
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
                    string query = "UPDATE Properties SET Address = @Address, City = @City, State = @State, ZipCode = @ZipCode, Price = @Price, Type = @Type, Bedrooms = @Bedrooms, Bathrooms = @Bathrooms, Description = @Description WHERE PropertyID = @PropertyID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@State", txtState.Text);
                    cmd.Parameters.AddWithValue("@ZipCode", txtZipCode.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@Type", cmbPropertyType.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Bedrooms", int.Parse(txtBedrooms.Text));
                    cmd.Parameters.AddWithValue("@Bathrooms", int.Parse(txtBathrooms.Text));
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@PropertyID", PropertyID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Property updated successfully!");
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
