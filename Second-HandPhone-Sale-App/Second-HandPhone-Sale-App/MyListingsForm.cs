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
    public partial class MyListingsForm : Form
    {
        private Dictionary<int, string[]> data;
        private int userId;
        private string userContact;
        public MyListingsForm(Dictionary<int, string[]> data, int userId, string userContact)
        {
            InitializeComponent();
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.userId = userId;
            this.userContact = userContact;
        }

        private void MyListingsForm_Load(object sender, EventArgs e)
        {
            LoadListings();
        }
        private void LoadListings()
        {

            var listings = data.Where(d => int.Parse(d.Value[0]) == userId).ToList();
            var dt = new DataTable();


            dt.Columns.Add("Model");
            dt.Columns.Add("Price");
            dt.Columns.Add("Condition");
            dt.Columns.Add("Description");

            foreach (var listing in listings)
            {
                var row = dt.NewRow();
                row["Model"] = listing.Value[1];
                row["Price"] = listing.Value[2];
                row["Condition"] = listing.Value[3];
                row["Description"] = listing.Value[4];
                dt.Rows.Add(row);
            }

            dataGridViewListings.DataSource = dt;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewListings.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewListings.SelectedRows[0];
                var model = selectedRow.Cells["Model"].Value.ToString();

                MessageBox.Show($"Edit functionality for {model} not implemented yet.");
            }
            else
            {
                MessageBox.Show("Please select a listing to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewListings.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewListings.SelectedRows[0];
                var model = selectedRow.Cells["Model"].Value.ToString();

                MessageBox.Show($"Delete functionality for {model} not implemented yet.");
            }
            else
            {
                MessageBox.Show("Please select a listing to delete.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListings();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userContact, data, userId, userContact);
            homeForm.ShowDialog();
        }


        private void logOutButton_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.ShowDialog();
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
            if (data == null || string.IsNullOrEmpty(userContact))
            {
                MessageBox.Show("User data or username is not available. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sell sellForm = new Sell(userContact, data, userId);
            sellForm.ShowDialog();
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
