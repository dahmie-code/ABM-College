namespace MoverPacker
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
            userText = new TextBox();
            user = new Label();
            signInButton = new Button();
            pass = new Label();
            passText = new TextBox();
            signIn = new Label();
            signInMessage = new Label();
            SuspendLayout();
            // 
            // userText
            // 
            userText.Location = new Point(234, 103);
            userText.Name = "userText";
            userText.Size = new Size(217, 23);
            userText.TabIndex = 0;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Location = new Point(116, 111);
            user.Name = "user";
            user.Size = new Size(38, 15);
            user.TabIndex = 1;
            user.Text = "label1";
            // 
            // signInButton
            // 
            signInButton.Location = new Point(308, 184);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(74, 27);
            signInButton.TabIndex = 2;
            signInButton.Text = "button1";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(116, 149);
            pass.Name = "pass";
            pass.Size = new Size(38, 15);
            pass.TabIndex = 3;
            pass.Text = "label2";
            // 
            // passText
            // 
            passText.Location = new Point(234, 141);
            passText.Name = "passText";
            passText.Size = new Size(217, 23);
            passText.TabIndex = 4;
            // 
            // signIn
            // 
            signIn.AutoSize = true;
            signIn.Location = new Point(308, 68);
            signIn.Name = "signIn";
            signIn.Size = new Size(38, 15);
            signIn.TabIndex = 5;
            signIn.Text = "label3";
            // 
            // signInMessage
            // 
            signInMessage.AutoSize = true;
            signInMessage.Location = new Point(234, 167);
            signInMessage.Name = "signInMessage";
            signInMessage.Size = new Size(38, 15);
            signInMessage.TabIndex = 6;
            signInMessage.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signInMessage);
            Controls.Add(signIn);
            Controls.Add(passText);
            Controls.Add(pass);
            Controls.Add(signInButton);
            Controls.Add(user);
            Controls.Add(userText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userText;
        private Label user;
        private Button signInButton;
        private Label pass;
        private TextBox passText;
        private Label signIn;
        private Label signInMessage;
    }
}