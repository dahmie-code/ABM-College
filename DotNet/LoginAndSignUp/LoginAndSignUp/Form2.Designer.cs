namespace LoginAndSignUp
{
    partial class Form2
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
            confirmPassword = new Label();
            newPasswordTextB = new TextBox();
            confirmPasswordTextB = new TextBox();
            forgotPSubmitButton = new Button();
            newPassword = new Label();
            SuspendLayout();
            // 
            // confirmPassword
            // 
            confirmPassword.AutoSize = true;
            confirmPassword.Location = new Point(76, 105);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(38, 15);
            confirmPassword.TabIndex = 1;
            confirmPassword.Text = "label2";
            // 
            // newPasswordTextB
            // 
            newPasswordTextB.Location = new Point(241, 52);
            newPasswordTextB.Name = "newPasswordTextB";
            newPasswordTextB.Size = new Size(151, 23);
            newPasswordTextB.TabIndex = 2;
            // 
            // confirmPasswordTextB
            // 
            confirmPasswordTextB.Location = new Point(241, 97);
            confirmPasswordTextB.Name = "confirmPasswordTextB";
            confirmPasswordTextB.Size = new Size(151, 23);
            confirmPasswordTextB.TabIndex = 3;
            // 
            // forgotPSubmitButton
            // 
            forgotPSubmitButton.Location = new Point(181, 160);
            forgotPSubmitButton.Name = "forgotPSubmitButton";
            forgotPSubmitButton.Size = new Size(75, 23);
            forgotPSubmitButton.TabIndex = 4;
            forgotPSubmitButton.Text = "button1";
            forgotPSubmitButton.UseVisualStyleBackColor = true;
            forgotPSubmitButton.Click += forgotPSubmitButton_Click;
            // 
            // newPassword
            // 
            newPassword.AutoSize = true;
            newPassword.Location = new Point(76, 60);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(38, 15);
            newPassword.TabIndex = 5;
            newPassword.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 337);
            Controls.Add(newPassword);
            Controls.Add(forgotPSubmitButton);
            Controls.Add(confirmPasswordTextB);
            Controls.Add(newPasswordTextB);
            Controls.Add(confirmPassword);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label confirmPassword;
        private TextBox newPasswordTextB;
        private TextBox confirmPasswordTextB;
        private Button forgotPSubmitButton;
        private Label newPassword;
    }
}