using System.Data;
using System.Windows.Forms;

namespace GridView
{
    public partial class Form1 : Form
    {
        private CheckBox headerCheckBox;
        private int currentPage = 1;
        private int pageSize = 2;
        private int totalRecords = 0;
        private int totalPages = 0;
        private List<DataRow> allDataRows = new List<DataRow>();
        private Button firstBtn;
        private Button previousBtn;
        private Button nextBtn;
        private Button lastBtn;
        public Form1()
        {
            InitializeComponent();
            searchBtn.Click += searchBtn_Click;
            updateBtn.Click += updateBtn_Click;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            AddCheckboxColumn();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            SetupHeaderCheckbox();
            name.Text = "Name";
            searchBtn.Text = "Search";
            deleteBtn.Text = "Delete";
            updateBtn.Text = "Update";
            dataGridView1.AllowUserToAddRows = false;
        }
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            DataTable dataTable = new DataTable();
            dataGridView1.Columns.Add("Model", "Model");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("Condition", "Condition");
            dataGridView1.Columns.Add("SellerContact", "Seller Contact");


            dataGridView1.Rows.Add("Pixel", "$200", "Good", "123-456-7890");
            dataGridView1.Rows.Add("OnePlus", "$150", "Like New", "345-678-9012");
            dataGridView1.Rows.Add("Samsung", "$300", "Fair", "234-567-8901");
            dataGridView1.Rows.Add("Redmi", "$250", "Excellent", "098-765-4321");
            dataGridView1.Rows.Add("OnePlus", "$150", "Good", "345-678-9012");
            dataGridView1.Rows.Add("iPhone", "$250", "Refurbished", "098-765-4321");

            dataGridView1.AllowUserToAddRows = false;
            allDataRows = dataTable.AsEnumerable().ToList();
            totalRecords = allDataRows.Count;
            totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);


            DisplayPage(1);
        }



        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex % 2 == 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
            }
        }
        private void SetupHeaderCheckbox()
        {

            headerCheckBox = new CheckBox
            {
                Size = new Size(20, 20),
                Checked = false,
            };


            headerCheckBox.CheckedChanged += HeaderCheckBox_CheckedChanged;


            DataGridViewCheckBoxCell headerCell = new DataGridViewCheckBoxCell
            {
                Value = false
            };


            dataGridView1.Controls.Add(headerCheckBox);
            headerCheckBox.BringToFront();

            PositionHeaderCheckBox();
        }
        private void PositionHeaderCheckBox()
        {
            if (dataGridView1.Columns.Count > 0)
            {

                Rectangle headerCellBounds = dataGridView1.GetCellDisplayRectangle(0, -1, true);


                headerCheckBox.Location = new Point(
                    headerCellBounds.Left + (headerCellBounds.Width - headerCheckBox.Width) / 2,
                    headerCellBounds.Top + (headerCellBounds.Height - headerCheckBox.Height) / 2
                );
            }
        }
        private void HeaderCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = headerCheckBox.Checked;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null)
                {
                    checkBoxCell.Value = isChecked;
                }
            }
        }
        private void AddCheckboxColumn()
        {

            if (dataGridView1.Columns["Select"] == null)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Select",
                    HeaderText = "",
                    Width = 50,
                    ReadOnly = false
                };

                dataGridView1.Columns.Insert(0, checkBoxColumn);
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell is DataGridViewCheckBoxCell)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                if (dataGridView1[e.ColumnIndex, e.RowIndex] is DataGridViewCheckBoxCell checkBoxCell)
                {
                    bool isChecked = Convert.ToBoolean(checkBoxCell.Value);

                }
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchText = searchBar.Text.Trim().ToLower();

            SearchInDataGridView(searchText);


        }
        private void ShowAllRows()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                row.Visible = true;
            }
        }
        private void SearchInDataGridView(string searchText)
        {
            bool anyVisible = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string cellValue = row.Cells["Model"].Value.ToString().ToLower();

                if (!string.IsNullOrEmpty(cellValue) && cellValue.Contains(searchText))
                {
                    row.Visible = true;
                    anyVisible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

            if (!anyVisible)
            {
                ShowAllRows();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;


                if (row.Cells["Select"] is DataGridViewCheckBoxCell checkBoxCell)
                {

                    if (checkBoxCell.Value is bool isChecked && isChecked)
                    {
                        rowsToRemove.Add(row);
                    }
                }
            }


            foreach (var row in rowsToRemove)
            {
                dataGridView1.Rows.Remove(row);
            }

            headerCheckBox.Checked = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;


            }
        }

        private void DisplayPage(int pageNumber)
        {
            int startRecord = (pageNumber - 1) * pageSize;
            int endRecord = Math.Min(startRecord + pageSize, totalRecords);

            dataGridView1.Rows.Clear();

            for (int i = startRecord; i < endRecord; i++)
            {
                DataRow row = allDataRows[i];
                dataGridView1.Rows.Add(row["Model"], row["Price"], row["Condition"], row["SellerContact"]);
            }

            //UpdatePaginationControls();
        }

    }
}