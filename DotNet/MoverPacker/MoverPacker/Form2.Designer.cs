namespace MoverPacker
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
            greetings = new Label();
            balanceLabel = new Label();
            logOutBtn = new Button();
            transferButton = new Button();
            amountTextBox = new TextBox();
            recipientTextBox = new TextBox();
            SentcomboBox = new ComboBox();
            ReceiverComboBox = new ComboBox();
            SuspendLayout();
            // 
            // greetings
            // 
            greetings.AutoSize = true;
            greetings.Location = new Point(506, 9);
            greetings.Name = "greetings";
            greetings.Size = new Size(38, 15);
            greetings.TabIndex = 0;
            greetings.Text = "label1";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(506, 43);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(38, 15);
            balanceLabel.TabIndex = 1;
            balanceLabel.Text = "label1";
            // 
            // logOutBtn
            // 
            logOutBtn.Location = new Point(723, 1);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(75, 23);
            logOutBtn.TabIndex = 2;
            logOutBtn.Text = "button1";
            logOutBtn.UseVisualStyleBackColor = true;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // transferButton
            // 
            transferButton.Location = new Point(233, 211);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(121, 23);
            transferButton.TabIndex = 3;
            transferButton.Text = "button1";
            transferButton.UseVisualStyleBackColor = true;
            transferButton.Click += transferButton_Click;
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(244, 120);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(100, 23);
            amountTextBox.TabIndex = 4;
            // 
            // recipientTextBox
            // 
            recipientTextBox.Location = new Point(244, 170);
            recipientTextBox.Name = "recipientTextBox";
            recipientTextBox.Size = new Size(100, 23);
            recipientTextBox.TabIndex = 5;
            // 
            // SentcomboBox
            // 
            SentcomboBox.FormattingEnabled = true;
            SentcomboBox.Location = new Point(81, 120);
            SentcomboBox.Name = "SentcomboBox";
            SentcomboBox.Size = new Size(121, 23);
            SentcomboBox.TabIndex = 6;
            // 
            // ReceiverComboBox
            // 
            ReceiverComboBox.FormattingEnabled = true;
            ReceiverComboBox.Location = new Point(81, 170);
            ReceiverComboBox.Name = "ReceiverComboBox";
            ReceiverComboBox.Size = new Size(121, 23);
            ReceiverComboBox.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 464);
            Controls.Add(ReceiverComboBox);
            Controls.Add(SentcomboBox);
            Controls.Add(recipientTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(transferButton);
            Controls.Add(logOutBtn);
            Controls.Add(balanceLabel);
            Controls.Add(greetings);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greetings;
        private Label balanceLabel;
        private Button logOutBtn;
        private Button transferButton;
        private TextBox amountTextBox;
        private TextBox recipientTextBox;
        private ComboBox SentcomboBox;
        private ComboBox ReceiverComboBox;
    }
}