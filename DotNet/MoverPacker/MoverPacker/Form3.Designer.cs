namespace MoverPacker
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
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            usernameLabel = new Label();
            SuspendLayout();
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(153, 167);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(120, 25);
            insertBtn.TabIndex = 0;
            insertBtn.Text = "button1";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += button1_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(353, 167);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(121, 23);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "button1";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(526, 167);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(124, 23);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "button1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(363, 104);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(38, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(usernameLabel);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Label usernameLabel;
    }
}