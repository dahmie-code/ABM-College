namespace E_commerce_Tool
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
            newPassword = new Label();
            confirmPassword = new Label();
            newPasswordTextB = new TextBox();
            confirmPasswordTextB = new TextBox();
            forgotPSubmitButton = new Button();
            SuspendLayout();
            // 
            // newPassword
            // 
            newPassword.AutoSize = true;
            newPassword.Location = new Point(211, 142);
            newPassword.Name = "newPassword";
            newPassword.Size = new Size(38, 15);
            newPassword.TabIndex = 0;
            newPassword.Text = "label1";
            // 
            // confirmPassword
            // 
            confirmPassword.AutoSize = true;
            confirmPassword.Location = new Point(211, 205);
            confirmPassword.Name = "confirmPassword";
            confirmPassword.Size = new Size(38, 15);
            confirmPassword.TabIndex = 1;
            confirmPassword.Text = "label1";
            // 
            // newPasswordTextB
            // 
            newPasswordTextB.Location = new Point(332, 139);
            newPasswordTextB.Name = "newPasswordTextB";
            newPasswordTextB.Size = new Size(203, 23);
            newPasswordTextB.TabIndex = 2;
            // 
            // confirmPasswordTextB
            // 
            confirmPasswordTextB.Location = new Point(332, 205);
            confirmPasswordTextB.Name = "confirmPasswordTextB";
            confirmPasswordTextB.Size = new Size(203, 23);
            confirmPasswordTextB.TabIndex = 3;
            // 
            // forgotPSubmitButton
            // 
            forgotPSubmitButton.Location = new Point(363, 267);
            forgotPSubmitButton.Name = "forgotPSubmitButton";
            forgotPSubmitButton.Size = new Size(116, 23);
            forgotPSubmitButton.TabIndex = 4;
            forgotPSubmitButton.Text = "button1";
            forgotPSubmitButton.UseVisualStyleBackColor = true;
            forgotPSubmitButton.Click += forgotPSubmitButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(forgotPSubmitButton);
            Controls.Add(confirmPasswordTextB);
            Controls.Add(newPasswordTextB);
            Controls.Add(confirmPassword);
            Controls.Add(newPassword);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label newPassword;
        private Label confirmPassword;
        private TextBox newPasswordTextB;
        private TextBox confirmPasswordTextB;
        private Button forgotPSubmitButton;
    }
}