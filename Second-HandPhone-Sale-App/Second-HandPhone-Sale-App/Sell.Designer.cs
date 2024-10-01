namespace Second_HandPhone_Sale_App
{
    partial class Sell
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
            modelTextBox = new TextBox();
            priceTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            contactTextBox = new TextBox();
            conditionComboBox = new ComboBox();
            submitButton = new Button();
            label1 = new Label();
            modelLabel = new Label();
            price = new Label();
            conditionLabel = new Label();
            descriptionLabel = new Label();
            contactLabel = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buyPhonesToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem1 = new ToolStripMenuItem();
            myListingsToolStripMenuItem = new ToolStripMenuItem();
            logOutButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(227, 83);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(212, 23);
            modelTextBox.TabIndex = 0;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(227, 131);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(212, 23);
            priceTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(227, 220);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(212, 23);
            descriptionTextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            contactTextBox.Location = new Point(227, 271);
            contactTextBox.Name = "contactTextBox";
            contactTextBox.Size = new Size(212, 23);
            contactTextBox.TabIndex = 3;
            // 
            // conditionComboBox
            // 
            conditionComboBox.FormattingEnabled = true;
            conditionComboBox.Location = new Point(227, 176);
            conditionComboBox.Name = "conditionComboBox";
            conditionComboBox.Size = new Size(212, 23);
            conditionComboBox.TabIndex = 4;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(285, 325);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 5;
            submitButton.Text = "button1";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += submitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 41);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(89, 91);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(38, 15);
            modelLabel.TabIndex = 7;
            modelLabel.Text = "label2";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(89, 139);
            price.Name = "price";
            price.Size = new Size(38, 15);
            price.TabIndex = 8;
            price.Text = "label3";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(89, 184);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(38, 15);
            conditionLabel.TabIndex = 9;
            conditionLabel.Text = "label4";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(89, 228);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(38, 15);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "label5";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(89, 279);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new Size(38, 15);
            contactLabel.TabIndex = 11;
            contactLabel.Text = "label6";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, buyPhonesToolStripMenuItem, profileToolStripMenuItem1, myListingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // buyPhonesToolStripMenuItem
            // 
            buyPhonesToolStripMenuItem.Name = "buyPhonesToolStripMenuItem";
            buyPhonesToolStripMenuItem.Size = new Size(81, 20);
            buyPhonesToolStripMenuItem.Text = "Buy Phones";
            buyPhonesToolStripMenuItem.Click += buyPhonesToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem1
            // 
            profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
            profileToolStripMenuItem1.Size = new Size(53, 20);
            profileToolStripMenuItem1.Text = "Profile";
            profileToolStripMenuItem1.Click += profileToolStripMenuItem1_Click;
            // 
            // myListingsToolStripMenuItem
            // 
            myListingsToolStripMenuItem.Name = "myListingsToolStripMenuItem";
            myListingsToolStripMenuItem.Size = new Size(79, 20);
            myListingsToolStripMenuItem.Text = "My Listings";
            myListingsToolStripMenuItem.Click += myListingsToolStripMenuItem_Click;
            // 
            // logOutButton
            // 
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.ForeColor = SystemColors.ButtonHighlight;
            logOutButton.Location = new Point(708, 2);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 13;
            logOutButton.Text = "button2";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // Sell
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logOutButton);
            Controls.Add(contactLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(conditionLabel);
            Controls.Add(price);
            Controls.Add(modelLabel);
            Controls.Add(label1);
            Controls.Add(submitButton);
            Controls.Add(conditionComboBox);
            Controls.Add(contactTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Sell";
            Text = "Sell";
            Load += Sell_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox modelTextBox;
        private TextBox priceTextBox;
        private TextBox descriptionTextBox;
        private TextBox contactTextBox;
        private ComboBox conditionComboBox;
        private Button submitButton;
        private Label label1;
        private Label modelLabel;
        private Label price;
        private Label conditionLabel;
        private Label descriptionLabel;
        private Label contactLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem buyPhonesToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem1;
        private Button logOutButton;
        private ToolStripMenuItem myListingsToolStripMenuItem;
    }
}