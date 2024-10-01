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
    public partial class addTransactionForm : Form
    {
        private TransactionManagement _transactionsForm;
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";
        public addTransactionForm(TransactionManagement transactionsForm)
        {
            InitializeComponent();
            _transactionsForm = transactionsForm;
        }

        private void addTransactionForm_Load(object sender, EventArgs e)
        {
            LoadTransactionTypes();
            LoadLabelsandButtons();
            LoadProperties();
            LoadOwners();

        }
        private void LoadTransactionTypes()
        {
            cmbTransactionType.Items.Add("Rent");
            cmbTransactionType.Items.Add("Buy");

        }
        private void LoadLabelsandButtons()
        {
            PptyIdLabel.Text = "Property address:";
            ownerIdLabel.Text = "Owner:";
            dateLabel.Text = "Date:";
            transLabel.Text = "Transaction Type:";
            amtLabel.Text = "Amount:";
            btnSave.Text = "Save";
            btnCancel.Text = "Cancel";
        }
        private void LoadProperties()
        {
            try {using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT PropertyID, Address FROM Properties";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPropertyID.DataSource = dt;
                cmbPropertyID.DisplayMember = "Address";
                cmbPropertyID.ValueMember = "PropertyID";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadOwners()
        {
            try {using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT OwnerID, CONCAT(FirstName, ' ', LastName) AS FullName FROM Owners";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbOwnerID.DataSource = dt;
                cmbOwnerID.DisplayMember = "FullName";
                cmbOwnerID.ValueMember = "OwnerID";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Transactions (PropertyID, OwnerID, TransactionDate, TransactionType, Amount) VALUES (@PropertyID, @OwnerID, @TransactionDate, @TransactionType, @Amount)";
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@PropertyID", cmbPropertyID.SelectedValue);
                    cmd.Parameters.AddWithValue("@OwnerID", cmbOwnerID.SelectedValue);
                    cmd.Parameters.AddWithValue("@TransactionDate", dateTransaction.Value);
                    cmd.Parameters.AddWithValue("@TransactionType", cmbTransactionType.SelectedItem.ToString());

                    decimal amount;
                    if (decimal.TryParse(txtAmount.Text, out amount))
                    {
                        cmd.Parameters.AddWithValue("@Amount", amount);
                    }
                    else
                    {
                        MessageBox.Show("Invalid amount. Please enter a valid decimal value.");
                        return;
                    }

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transaction added successfully!");

                    _transactionsForm.LoadTransactions();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
