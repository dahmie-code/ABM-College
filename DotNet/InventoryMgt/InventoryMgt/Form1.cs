using System.Data.SqlClient;

namespace InventoryMgt
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=ABMtest; User Id =sa; Password=password123;";
        int availableQuantity = 0;
        int addedQuantity = 0;
        public Form1()
        {
            InitializeComponent();
            LoadItemDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Text = "+";
            btnRemove.Text = "-";
            btnSave.Text = "Proceed";
            btnInsert.Text = "Insert";
            btnUpdate.Text = "Update";
            itemLabel.Text = "Keyboard";
            quantityLabel.Text = "0";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            addedQuantity++;
            quantityLabel.Text = addedQuantity.ToString();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (addedQuantity > 0)
            {
                addedQuantity--;
                quantityLabel.Text = addedQuantity.ToString();
            }
            else
            {
                MessageBox.Show("You can't reduce below 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadItemDetails()
        {
            int itemId = 1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Quantity FROM Inventory WHERE ItemID = @ItemID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ItemID", itemId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    availableQuantity = reader.GetInt32(0);
                }

                reader.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (addedQuantity > availableQuantity)
            {
                MessageBox.Show("You are trying to add more than what's available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {

                    string updateQuery = "UPDATE Inventory SET Quantity = Quantity - @Quantity WHERE ItemID = @ItemID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@Quantity", addedQuantity);
                    updateCmd.Parameters.AddWithValue("@ItemID", 1);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {

                        transaction.Commit();
                        MessageBox.Show("Quantity updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Please check the item ID and quantity.");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    for (int i = 1; i <= 100; i++)
                    {

                        if (i == 52)
                        {
                            throw new Exception("There is error on record 52");
                        }

                        string itemName = "Item" + i;
                        int quantity = i + 10;

                        string insertQuery = "INSERT INTO Inventory (ItemName, Quantity) VALUES (@ItemName, @Quantity)";
                        SqlCommand cmd = new SqlCommand(insertQuery, conn, transaction);

                        cmd.Parameters.AddWithValue("@ItemName", itemName);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);


                        cmd.ExecuteNonQuery();
                    }


                    transaction.Commit();
                    MessageBox.Show("100 records inserted successfully!");
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    MessageBox.Show("An error occurred while inserting records. No records were inserted. Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction(); 

                try
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        if (i == 45)
                        {
                            throw new Exception("There is error on record 45");
                        }
                        int itemId = i;                 
                        int newQuantity = i + 20;       


                        string updateQuery = "UPDATE Inventory SET Quantity = @Quantity WHERE ItemID = @ItemID";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn, transaction);

                   
                        cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                        cmd.Parameters.AddWithValue("@ItemID", itemId);

                       
                        cmd.ExecuteNonQuery();
                    }


                    transaction.Commit();
                    MessageBox.Show("100 records updated successfully!");
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    MessageBox.Show("An error occurred while updating records. No records were updated. Error: " + ex.Message);
                }
            }
        }
    }
}