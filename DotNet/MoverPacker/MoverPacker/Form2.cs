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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MoverPacker
{
    public partial class Form2 : Form
    {
        private decimal userBalance;
        private string firstname;
        private string role;
        private string currentUsername;
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=AUGUST2024; User Id =sa; Password=password123;";

        public Form2(string firstName, string role, decimal balance)
        {
            InitializeComponent();
            LoadData(firstName, role, balance);
            LoadCurrentUsername();
            ReceiversComboBox();
        }

        private void LoadData(string firstName, string role, decimal balance)
        {
            this.firstname = firstName;
            this.role = role;
            this.userBalance = balance;

            greetings.Text = $"Hi {role}, {firstname}!";
            balanceLabel.Text = $"Your balance: ${userBalance}";
        }
        private void LoadCurrentUsername()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Username FROM Users WHERE FirstName = @FirstName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", this.firstname);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        this.currentUsername = reader["Username"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Username not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading the username: " + ex.Message);
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.currentUsername))
            {
                SentcomboBox.Text = this.currentUsername;
            }
            else
            {
                SentcomboBox.Text = "--Username not found--";
            }

            ReceiverComboBox.Text = "--Receiver--";
            logOutBtn.Text = "Log Out";
            transferButton.Text = "Transfer Fund";

        }



        private void ReceiversComboBox()
        {
            ReceiverComboBox.Items.Clear(); 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Username FROM Users WHERE Username != @CurrentUsername";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CurrentUsername", this.currentUsername);


                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ReceiverComboBox.Items.Add(reader["Username"].ToString());
                    }

                    if (ReceiverComboBox.Items.Count > 0)
                    {
                        ReceiverComboBox.SelectedIndex = 0; // Select the first item by default
                    }
                    else
                    {
                        ReceiverComboBox.Text = "--No Users Available--"; // Display a message if no users are found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading receivers: " + ex.Message);
                }
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(amountTextBox.Text);
            string recipientUsername = recipientTextBox.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Deduct from sender
                    string deductQuery = "UPDATE Wallet SET Balance = Balance - @Amount WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)";
                    SqlCommand deductCommand = new SqlCommand(deductQuery, connection, transaction);
                    deductCommand.Parameters.AddWithValue("@Amount", amount);
                    deductCommand.Parameters.AddWithValue("@Username", this.currentUsername);
                    deductCommand.ExecuteNonQuery();

                    // Add to recipient
                    string addQuery = "UPDATE Wallet SET Balance = Balance + @Amount WHERE UserID = (SELECT UserID FROM Users WHERE Username = @RecipientUsername)";
                    SqlCommand addCommand = new SqlCommand(addQuery, connection, transaction);
                    addCommand.Parameters.AddWithValue("@Amount", amount);
                    addCommand.Parameters.AddWithValue("@RecipientUsername", recipientUsername);
                    addCommand.ExecuteNonQuery();

                    // Record transaction for sender
                    string senderTransactionQuery = "INSERT INTO Transactions (WalletID, Amount, TransactionType, TransactionDate) VALUES ((SELECT WalletID FROM Wallet WHERE UserID = (SELECT UserID FROM Users WHERE Username = @Username)), @Amount, 'Debit', GETDATE())";
                    SqlCommand senderTransactionCommand = new SqlCommand(senderTransactionQuery, connection, transaction);
                    senderTransactionCommand.Parameters.AddWithValue("@Username", this.currentUsername);
                    senderTransactionCommand.Parameters.AddWithValue("@Amount", -amount);
                    senderTransactionCommand.ExecuteNonQuery();

                    // Record transaction for recipient
                    string recipientTransactionQuery = "INSERT INTO Transactions (WalletID, Amount, TransactionType, TransactionDate) VALUES ((SELECT WalletID FROM Wallet WHERE UserID = (SELECT UserID FROM Users WHERE Username = @RecipientUsername)), @Amount, 'Credit', GETDATE())";
                    SqlCommand recipientTransactionCommand = new SqlCommand(recipientTransactionQuery, connection, transaction);
                    recipientTransactionCommand.Parameters.AddWithValue("@RecipientUsername", recipientUsername);
                    recipientTransactionCommand.Parameters.AddWithValue("@Amount", amount);
                    recipientTransactionCommand.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Transfer successful!");

                    // Update balance
                    userBalance -= amount;
                    balanceLabel.Text = $"Your balance: ${userBalance}";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
