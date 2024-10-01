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
    public partial class TransactionManagement : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=PptyMgt; User Id=sa; Password=password123;";
        public TransactionManagement()
        {
            InitializeComponent();
        }

        private void TransactionManagement_Load(object sender, EventArgs e)
        {
            LoadTransactions();
            LoadTransactionTypes();
            LoadLabelsandButtons();
        }
        private void LoadTransactionTypes()
        {
            cmbTransactionType.Items.Add("Rent");
            cmbTransactionType.Items.Add("Buy");
            cmbTransactionType.Items.Add("All");
            cmbTransactionType.SelectedIndex = 2;
        }
        private void LoadLabelsandButtons()
        {
            PptyIdLabel.Text = "Property ID:";
            ownerIdLabel.Text = "Owner ID:";
            startDateLabel.Text = "From:";
            endDateLabel.Text = "To:";
            transLabel.Text = "Transaction Type:";
            btnFilter.Text = "Filter";
            btnAddTransaction.Text = "Add";
            btnRefresh.Text = "Refresh";

        }
        public void LoadTransactions()
        {
            try { using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT t.TransactionID, t.PropertyID, t.OwnerID, t.TransactionDate, t.TransactionType, t.Amount, " +
                               "p.Address, o.FirstName + ' ' + o.LastName AS OwnerName " +
                               "FROM Transactions t " +
                               "INNER JOIN Properties p ON t.PropertyID = p.PropertyID " +
                               "INNER JOIN Owners o ON t.OwnerID = o.OwnerID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                    dataGridViewTransactions.DataSource = dt;
                    dataGridViewTransactions.Columns["TransactionDate"].DefaultCellStyle.Format = "dd-MM-yyyy";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }


        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                addTransactionForm addForm = new addTransactionForm(this);
                addForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                txtPropertyID.Clear();
                txtOwnerID.Clear();
                cmbTransactionType.SelectedIndex = 2;
                dateStartDate.Value = DateTime.Now.AddMonths(-1);
                dateEndDate.Value = DateTime.Now;
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT t.TransactionID, t.PropertyID, t.OwnerID, t.TransactionDate, t.TransactionType, t.Amount, " +
                                   "p.Address, o.FirstName + ' ' + o.LastName AS OwnerName " +
                                   "FROM Transactions t " +
                                   "INNER JOIN Properties p ON t.PropertyID = p.PropertyID " +
                                   "INNER JOIN Owners o ON t.OwnerID = o.OwnerID " +
                                   "WHERE (t.PropertyID = @PropertyID OR @PropertyID = '') " +
                                   "AND (t.OwnerID = @OwnerID OR @OwnerID = '') " +
                                   "AND (t.TransactionType = @TransactionType OR @TransactionType = 'All') " +
                                   "AND (t.TransactionDate BETWEEN @StartDate AND @EndDate)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@PropertyID", string.IsNullOrEmpty(txtPropertyID.Text) ? (object)DBNull.Value : txtPropertyID.Text);
                    cmd.Parameters.AddWithValue("@OwnerID", string.IsNullOrEmpty(txtOwnerID.Text) ? (object)DBNull.Value : txtOwnerID.Text);
                    cmd.Parameters.AddWithValue("@TransactionType", cmbTransactionType.SelectedItem?.ToString() ?? "All");
                    cmd.Parameters.AddWithValue("@StartDate", dateStartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", dateEndDate.Value);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewTransactions.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}
