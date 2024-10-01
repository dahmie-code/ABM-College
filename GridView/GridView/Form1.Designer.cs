namespace GridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            name = new Label();
            searchBar = new TextBox();
            searchBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            firstBtn = new Button();
            lastBtn = new Button();
            prevBtn = new Button();
            nextBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(606, 332);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(30, 18);
            name.Name = "name";
            name.Size = new Size(38, 15);
            name.TabIndex = 1;
            name.Text = "label1";
            // 
            // searchBar
            // 
            searchBar.Location = new Point(114, 15);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(216, 23);
            searchBar.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(363, 15);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "button1";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(561, 14);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "button1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(462, 14);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 23);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "button1";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // firstBtn
            // 
            firstBtn.Location = new Point(30, 396);
            firstBtn.Name = "firstBtn";
            firstBtn.Size = new Size(75, 23);
            firstBtn.TabIndex = 6;
            firstBtn.Text = "button1";
            firstBtn.UseVisualStyleBackColor = true;
            // 
            // lastBtn
            // 
            lastBtn.Location = new Point(561, 396);
            lastBtn.Name = "lastBtn";
            lastBtn.Size = new Size(75, 23);
            lastBtn.TabIndex = 7;
            lastBtn.Text = "button1";
            lastBtn.UseVisualStyleBackColor = true;
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(242, 396);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(37, 23);
            prevBtn.TabIndex = 8;
            prevBtn.Text = "button1";
            prevBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(363, 396);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(37, 23);
            nextBtn.TabIndex = 9;
            nextBtn.Text = "button1";
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(lastBtn);
            Controls.Add(firstBtn);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(searchBtn);
            Controls.Add(searchBar);
            Controls.Add(name);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label name;
        private TextBox searchBar;
        private Button searchBtn;
        private Button deleteBtn;
        private Button updateBtn;
        private Button firstBtn;
        private Button lastBtn;
        private Button prevBtn;
        private Button nextBtn;
    }
}