namespace Stored_Procedure
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            btnStart = new Button();
            btnEnd = new Button();
            btnContain = new Button();
            btnSearch = new Button();
            txtGroceryDesc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(754, 245);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 34);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(155, 23);
            textBoxSearch.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(173, 34);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(130, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "button1";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(309, 33);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(130, 23);
            btnEnd.TabIndex = 3;
            btnEnd.Text = "button2";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnContain
            // 
            btnContain.Location = new Point(445, 33);
            btnContain.Name = "btnContain";
            btnContain.Size = new Size(124, 23);
            btnContain.TabIndex = 4;
            btnContain.Text = "button3";
            btnContain.UseVisualStyleBackColor = true;
            btnContain.Click += btnContain_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(575, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "button3";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtGroceryDesc
            // 
            txtGroceryDesc.Location = new Point(12, 5);
            txtGroceryDesc.Name = "txtGroceryDesc";
            txtGroceryDesc.Size = new Size(155, 23);
            txtGroceryDesc.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtGroceryDesc);
            Controls.Add(btnSearch);
            Controls.Add(btnContain);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Button btnStart;
        private Button btnEnd;
        private Button btnContain;
        private Button btnSearch;
        private TextBox txtGroceryDesc;
    }
}