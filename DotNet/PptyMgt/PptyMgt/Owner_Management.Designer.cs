namespace PptyMgt
{
    partial class Owner_Management
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
            deleteBtn = new Button();
            updateBtn = new Button();
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(329, 376);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(153, 23);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "button1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(170, 376);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(153, 23);
            updateBtn.TabIndex = 20;
            updateBtn.Text = "button1";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 314);
            dataGridView1.TabIndex = 19;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 23);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Owner_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Name = "Owner_Management";
            Text = "Owner_Management";
            Load += Owner_Management_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button deleteBtn;
        private Button updateBtn;
        private DataGridView dataGridView1;
        private Button btnAdd;
    }
}