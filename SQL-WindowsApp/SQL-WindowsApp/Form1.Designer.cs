namespace SQL_WindowsApp
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
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            txtGender = new TextBox();
            btnSearch = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            changeBGColor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 23);
            comboBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(857, 272);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(444, 67);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(117, 23);
            txtGender.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(665, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "button1";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(75, 67);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(117, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(198, 67);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(117, 23);
            txtLastName.TabIndex = 5;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(321, 67);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(117, 23);
            txtAge.TabIndex = 6;
            // 
            // changeBGColor
            // 
            changeBGColor.Location = new Point(665, 374);
            changeBGColor.Name = "changeBGColor";
            changeBGColor.Size = new Size(204, 23);
            changeBGColor.TabIndex = 7;
            changeBGColor.Text = "button1";
            changeBGColor.UseVisualStyleBackColor = true;
            changeBGColor.Click += changeBGColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 532);
            Controls.Add(changeBGColor);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSearch);
            Controls.Add(txtGender);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private TextBox txtGender;
        private Button btnSearch;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private Button changeBGColor;
    }
}