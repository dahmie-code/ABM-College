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

namespace Stored_Procedure
{
    public partial class Form5 : Form
    {
        private string connectionString = @"Server=DAMICODE\SQLEXPRESS; Database=Auth; User Id =sa; Password=password123;";
        //private bool isDataModified = false;
        private bool canWrite = false;
        private int editedRowId = -1;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button1.Text = "Login";
            label1.Text = "Username";
            dataGridView1.Visible = false;
            button2.Text = "Log Out";
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            if (CheckUserCanRead(userName))
            {
                dataGridView1.Visible = true;
                LoadUserData();
            }
            else
            {
                MessageBox.Show("You do not have read access.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool CheckUserCanRead(string userName)
        {
            bool canRead = false;
            string query = "SELECT RW FROM UserRights WHERE [User] = @UserName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", userName);

                try
                {
                    conn.Open();
                    string permission = cmd.ExecuteScalar()?.ToString();

                    if (permission == "R")
                    {
                        canRead = true;
                        canWrite = false;
                    }
                    else if (permission == "W")
                    {
                        canRead = true;
                        canWrite = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return canRead;
        }
        private void LoadUserData()
        {
            string query = "SELECT DataId, DataName, Description FROM UserData";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();

                try
                {
                    conn.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    if (dataGridView1.Columns.Contains("DataId"))
                    {
                        dataGridView1.Columns["DataId"].Visible = false;
                    }
                    if (!canWrite)
                    {
                        dataGridView1.ReadOnly = true;
                        MessageBox.Show("You have read-only access.", "Access Limited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.ReadOnly = false;
                        if (!dataGridView1.Columns.Contains("Delete"))
                        {
                            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                            deleteButton.HeaderText = "";
                            deleteButton.Text = "Delete";
                            deleteButton.UseColumnTextForButtonValue = true;
                            deleteButton.Name = "Delete";

                            dataGridView1.Columns.Add(deleteButton);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            textBox1.Clear();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells["DataId"].Value != null)
            {
                editedRowId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DataId"].Value);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (editedRowId != -1)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                string newValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                UpdateDatabase(editedRowId, columnName, newValue);

            }
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.EndEdit();
            }

            if (editedRowId != -1 & canWrite)
            {
                MessageBox.Show("Saving changes...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.BeginInvoke(new MethodInvoker(() => LoadUserData()));

            }
        }
        private void UpdateDatabase(int dataId, string columnName, string newValue)
        {
            string query = $"UPDATE UserData SET {columnName} = @NewValue WHERE DataId = @DataId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NewValue", newValue);
                cmd.Parameters.AddWithValue("@DataId", dataId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No rows updated. Check if DataId is correct.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int dataId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["DataId"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRecord(dataId);

                    LoadUserData();
                }
            }
        }
        private void DeleteRecord(int dataId)
        {
            string query = "DELETE FROM UserData WHERE DataId = @DataId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DataId", dataId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record deleted. Check if DataId is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
