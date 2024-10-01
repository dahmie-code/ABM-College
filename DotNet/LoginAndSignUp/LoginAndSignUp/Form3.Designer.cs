namespace LoginAndSignUp
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
            greetings = new Label();
            welcomeMessage = new Label();
            SuspendLayout();
            // 
            // greetings
            // 
            greetings.AutoSize = true;
            greetings.Location = new Point(614, 9);
            greetings.Name = "greetings";
            greetings.Size = new Size(38, 15);
            greetings.TabIndex = 0;
            greetings.Text = "label1";
            // 
            // welcomeMessage
            // 
            welcomeMessage.AutoSize = true;
            welcomeMessage.Location = new Point(347, 149);
            welcomeMessage.Name = "welcomeMessage";
            welcomeMessage.Size = new Size(38, 15);
            welcomeMessage.TabIndex = 1;
            welcomeMessage.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 499);
            Controls.Add(welcomeMessage);
            Controls.Add(greetings);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greetings;
        private Label welcomeMessage;
    }
}