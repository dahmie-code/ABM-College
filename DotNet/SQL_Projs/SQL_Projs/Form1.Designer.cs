namespace SQL_Projs
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
            create = new Button();
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            emailTextBox = new TextBox();
            dobDatePicker = new DateTimePicker();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // create
            // 
            create.Location = new Point(120, 237);
            create.Name = "create";
            create.Size = new Size(75, 23);
            create.TabIndex = 0;
            create.Text = "button1";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(120, 107);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(171, 23);
            nameTextBox.TabIndex = 1;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(120, 136);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(100, 23);
            ageTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(120, 165);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(171, 23);
            emailTextBox.TabIndex = 3;
            // 
            // dobDatePicker
            // 
            dobDatePicker.Location = new Point(120, 194);
            dobDatePicker.Name = "dobDatePicker";
            dobDatePicker.Size = new Size(200, 23);
            dobDatePicker.TabIndex = 5;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(388, 237);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "button1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteBtn);
            Controls.Add(dobDatePicker);
            Controls.Add(emailTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(create);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create;
        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private TextBox emailTextBox;
        private DateTimePicker dobDatePicker;
        private Button deleteBtn;
    }
}