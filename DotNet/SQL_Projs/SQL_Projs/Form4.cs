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

namespace SQL_Projs
{
    public partial class Form4 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=AUGUST2024; User Id=sa; Password=password123;";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Buyer Id";
            label2.Text = "Product Id";
            label3.Text = "Quantity";
            label4.Text = "Total Price";
            label5.Text = "Order Id";

            btnPlaceOrder.Text = "Place Order";
            updateBtn.Text = "Update Order";
            deleteBtn.Text = "Delete";

            LoadOrderLog();

        }
        public void InsertOrder(int buyerId, int productId, int quantity, decimal totalPrice)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Purchase (BuyerID, ProductID, Quantity, TotalPrice) VALUES (@BuyerID, @ProductID, @Quantity, @TotalPrice)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BuyerID", buyerId);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void UpdateOrder(int orderId, int newQuantity, decimal newTotalPrice)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Purchase SET Quantity = @NewQuantity, TotalPrice = @NewTotalPrice WHERE OrderID = @OrderID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                cmd.Parameters.AddWithValue("@NewTotalPrice", newTotalPrice);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void DeleteOrder(int orderId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Purchase WHERE OrderID = @OrderID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadOrderLog()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetOrderLog", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    conn.Open();
                    adapter.Fill(dataTable);


                    dataGridViewOrderLog.DataSource = dataTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int buyerId = Convert.ToInt32(txtBuyerId.Text);
                int productId = Convert.ToInt32(txtProductId.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                decimal totalPrice = Convert.ToDecimal(txtTotalPrice.Text);


                InsertOrder(buyerId, productId, quantity, totalPrice);

                MessageBox.Show("Order placed successfully!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(txtOrderId.Text);
                int newQuantity = Convert.ToInt32(txtQuantity.Text);
                decimal newTotalPrice = Convert.ToDecimal(txtTotalPrice.Text);

                UpdateOrder(orderId, newQuantity, newTotalPrice);

                MessageBox.Show("Order updated successfully!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(txtOrderId.Text);

                DeleteOrder(orderId);

                MessageBox.Show("Order deleted successfully!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Input format error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}
