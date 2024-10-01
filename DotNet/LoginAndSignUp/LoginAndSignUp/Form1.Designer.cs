namespace LoginAndSignUp
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
            signUp = new Label();
            userName = new Label();
            password = new Label();
            confirmPassword = new Label();
            userTextBox = new TextBox();
            passwordTextBox = new TextBox();
            confirmTextBox = new TextBox();
            signUpButton = new Button();
            message = new Label();
            signIn = new Label();
            user = new Label();
            pass = new Label();
            userText = new TextBox();
            passText = new TextBox();
            signInMessage = new Label();
            signInButton = new Button();
            forgotPassword = new Button();
            fName = new Label();
            lName = new Label();
            fNametextBox = new TextBox();
            lNametextBox = new TextBox();
            SuspendLayout();
            // 
            // signUp
            // 
            signUp.AutoSize = true;
            signUp.Location = new Point(216, 25);
            signUp.Name = "signUp";
            signUp.Size = new Size(38, 15);
            signUp.TabIndex = 0;
            signUp.Text = "label1";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(19, 72);
            userName.Name = "userName";
            userName.Size = new Size(38, 15);
            userName.TabIndex = 1;
            userName.Text = "label2";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(19, 235);
            password.Name = "password";
            password.Size = new Size(38, 15);
            password.TabIndex = 2;
            password.Text = "label1";
            // 
            // confirmPassword
            // 
            confirmPassword.AutoSize = true;
            confirmPassword.Location = new Point(19, 288);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(38, 15);
            confirmPassword.TabIndex = 3;
            confirmPassword.Text = "label1";
            // 
            // userTextBox
            // 
            userTextBox.Location = new Point(151, 69);
            userTextBox.Name = "userTextBox";
            userTextBox.Size = new Size(234, 23);
            userTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(151, 232);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(234, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // confirmTextBox
            // 
            confirmTextBox.Location = new Point(151, 285);
            confirmTextBox.Name = "confirmTextBox";
            confirmTextBox.Size = new Size(234, 23);
            confirmTextBox.TabIndex = 6;
            // 
            // signUpButton
            // 
            signUpButton.Location = new Point(216, 426);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(75, 23);
            signUpButton.TabIndex = 7;
            signUpButton.Text = "button1";
            signUpButton.UseVisualStyleBackColor = true;
            signUpButton.Click += signUpButton_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(151, 363);
            message.Name = "message";
            message.Size = new Size(38, 15);
            message.TabIndex = 9;
            message.Text = "label2";
            // 
            // signIn
            // 
            signIn.AutoSize = true;
            signIn.Location = new Point(604, 25);
            signIn.Name = "signIn";
            signIn.Size = new Size(38, 15);
            signIn.TabIndex = 10;
            signIn.Text = "label1";
            // 
            // user
            // 
            user.AutoSize = true;
            user.Location = new Point(461, 72);
            user.Name = "user";
            user.Size = new Size(38, 15);
            user.TabIndex = 11;
            user.Text = "label1";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(461, 135);
            pass.Name = "pass";
            pass.Size = new Size(38, 15);
            pass.TabIndex = 12;
            pass.Text = "label2";
            // 
            // userText
            // 
            userText.Location = new Point(661, 69);
            userText.Name = "userText";
            userText.Size = new Size(209, 23);
            userText.TabIndex = 13;
            // 
            // passText
            // 
            passText.Location = new Point(661, 123);
            passText.Name = "passText";
            passText.Size = new Size(207, 23);
            passText.TabIndex = 14;
            // 
            // signInMessage
            // 
            signInMessage.AutoSize = true;
            signInMessage.Location = new Point(661, 177);
            signInMessage.Name = "signInMessage";
            signInMessage.Size = new Size(38, 15);
            signInMessage.TabIndex = 15;
            signInMessage.Text = "label1";
            // 
            // signInButton
            // 
            signInButton.Location = new Point(661, 227);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(75, 23);
            signInButton.TabIndex = 16;
            signInButton.Text = "button1";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // forgotPassword
            // 
            forgotPassword.Location = new Point(795, 227);
            forgotPassword.Name = "forgotPassword";
            forgotPassword.Size = new Size(75, 23);
            forgotPassword.TabIndex = 17;
            forgotPassword.Text = "button1";
            forgotPassword.UseVisualStyleBackColor = true;
            forgotPassword.Click += forgotPassword_Click;
            // 
            // fName
            // 
            fName.AutoSize = true;
            fName.Location = new Point(19, 126);
            fName.Name = "fName";
            fName.Size = new Size(38, 15);
            fName.TabIndex = 18;
            fName.Text = "label1";
            // 
            // lName
            // 
            lName.AutoSize = true;
            lName.Location = new Point(19, 182);
            lName.Name = "lName";
            lName.Size = new Size(38, 15);
            lName.TabIndex = 19;
            lName.Text = "label1";
            // 
            // fNametextBox
            // 
            fNametextBox.Location = new Point(151, 123);
            fNametextBox.Name = "fNametextBox";
            fNametextBox.Size = new Size(234, 23);
            fNametextBox.TabIndex = 20;
            // 
            // lNametextBox
            // 
            lNametextBox.Location = new Point(151, 174);
            lNametextBox.Name = "lNametextBox";
            lNametextBox.Size = new Size(234, 23);
            lNametextBox.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 543);
            Controls.Add(lNametextBox);
            Controls.Add(fNametextBox);
            Controls.Add(lName);
            Controls.Add(fName);
            Controls.Add(forgotPassword);
            Controls.Add(signInButton);
            Controls.Add(signInMessage);
            Controls.Add(passText);
            Controls.Add(userText);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(signIn);
            Controls.Add(message);
            Controls.Add(signUpButton);
            Controls.Add(confirmTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(userTextBox);
            Controls.Add(confirmPassword);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(signUp);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label signUp;
        private Label userName;
        private Label password;
        private Label confirmPassword;
        private TextBox userTextBox;
        private TextBox passwordTextBox;
        private TextBox confirmTextBox;
        private Button signUpButton;
        private Label message;
        private Label signIn;
        private Label user;
        private Label pass;
        private TextBox userText;
        private TextBox passText;
        private Label signInMessage;
        private Button signInButton;
        private Button forgotPassword;
        private Label fName;
        private Label lName;
        private TextBox fNametextBox;
        private TextBox lNametextBox;
    }
}