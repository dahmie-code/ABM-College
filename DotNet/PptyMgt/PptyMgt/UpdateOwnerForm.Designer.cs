namespace PptyMgt
{
    partial class UpdateOwnerForm
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
            cancelBtn = new Button();
            saveBtn = new Button();
            addressLabel = new Label();
            emailLabel = new Label();
            phoneNumberLabel = new Label();
            lastnameLabel = new Label();
            addrs = new TextBox();
            email = new TextBox();
            phoneNumber = new TextBox();
            lastName = new TextBox();
            firstName = new TextBox();
            firstNameLabel = new Label();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(481, 269);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 52;
            cancelBtn.Text = "button2";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(312, 269);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 51;
            saveBtn.Text = "button1";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(80, 224);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(38, 15);
            addressLabel.TabIndex = 50;
            addressLabel.Text = "label5";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(436, 195);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(38, 15);
            emailLabel.TabIndex = 49;
            emailLabel.Text = "label4";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(80, 195);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(38, 15);
            phoneNumberLabel.TabIndex = 48;
            phoneNumberLabel.Text = "label3";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Location = new Point(436, 166);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(38, 15);
            lastnameLabel.TabIndex = 47;
            lastnameLabel.Text = "label2";
            // 
            // addrs
            // 
            addrs.Location = new Point(203, 216);
            addrs.Name = "addrs";
            addrs.Size = new Size(166, 23);
            addrs.TabIndex = 46;
            // 
            // email
            // 
            email.Location = new Point(554, 187);
            email.Name = "email";
            email.Size = new Size(166, 23);
            email.TabIndex = 45;
            // 
            // phoneNumber
            // 
            phoneNumber.Location = new Point(203, 187);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(166, 23);
            phoneNumber.TabIndex = 44;
            // 
            // lastName
            // 
            lastName.Location = new Point(554, 158);
            lastName.Name = "lastName";
            lastName.Size = new Size(166, 23);
            lastName.TabIndex = 43;
            // 
            // firstName
            // 
            firstName.Location = new Point(203, 158);
            firstName.Multiline = true;
            firstName.Name = "firstName";
            firstName.Size = new Size(166, 23);
            firstName.TabIndex = 42;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(80, 166);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(38, 15);
            firstNameLabel.TabIndex = 41;
            firstNameLabel.Text = "label1";
            // 
            // UpdateOwnerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(addressLabel);
            Controls.Add(emailLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(lastnameLabel);
            Controls.Add(addrs);
            Controls.Add(email);
            Controls.Add(phoneNumber);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(firstNameLabel);
            Name = "UpdateOwnerForm";
            Text = "UpdateOwnerForm";
            Load += UpdateOwnerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private Label addressLabel;
        private Label emailLabel;
        private Label phoneNumberLabel;
        private Label lastnameLabel;
        private TextBox addrs;
        private TextBox email;
        private TextBox phoneNumber;
        private TextBox lastName;
        private TextBox firstName;
        private Label firstNameLabel;
    }
}