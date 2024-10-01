namespace Second_HandPhone_Sale_App
{
    partial class UserProfileForm
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
            fNameTextBox = new TextBox();
            fNamelabel = new Label();
            lNameLabel = new Label();
            userNameLabel = new Label();
            passwordLabel = new Label();
            lNameTextBox = new TextBox();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            saveButton = new Button();
            userProfLabel = new Label();
            SuspendLayout();
            // 
            // fNameTextBox
            // 
            fNameTextBox.Location = new Point(210, 90);
            fNameTextBox.Name = "fNameTextBox";
            fNameTextBox.Size = new Size(239, 23);
            fNameTextBox.TabIndex = 0;
            // 
            // fNamelabel
            // 
            fNamelabel.AutoSize = true;
            fNamelabel.Location = new Point(84, 98);
            fNamelabel.Name = "fNamelabel";
            fNamelabel.Size = new Size(38, 15);
            fNamelabel.TabIndex = 2;
            fNamelabel.Text = "label2";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new Point(84, 149);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new Size(38, 15);
            lNameLabel.TabIndex = 3;
            lNameLabel.Text = "label3";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(84, 200);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(38, 15);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "label4";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(84, 250);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(38, 15);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "label5";
            // 
            // lNameTextBox
            // 
            lNameTextBox.Location = new Point(210, 141);
            lNameTextBox.Name = "lNameTextBox";
            lNameTextBox.Size = new Size(239, 23);
            lNameTextBox.TabIndex = 6;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(210, 192);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(239, 23);
            userNameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(210, 242);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(239, 23);
            passwordTextBox.TabIndex = 8;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(290, 294);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 9;
            saveButton.Text = "button1";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click_1;
            // 
            // userProfLabel
            // 
            userProfLabel.AutoSize = true;
            userProfLabel.Location = new Point(210, 53);
            userProfLabel.Name = "userProfLabel";
            userProfLabel.Size = new Size(38, 15);
            userProfLabel.TabIndex = 10;
            userProfLabel.Text = "label1";
            // 
            // UserProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(userProfLabel);
            Controls.Add(saveButton);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(lNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(lNameLabel);
            Controls.Add(fNamelabel);
            Controls.Add(fNameTextBox);
            Name = "UserProfileForm";
            Text = "UserProfileForm";
            Load += UserProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fNameTextBox;
        private Label fNamelabel;
        private Label lNameLabel;
        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox lNameTextBox;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private Button saveButton;
        private Label userProfLabel;
    }
}