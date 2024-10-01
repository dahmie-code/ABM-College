namespace Second_HandPhone_Sale_App
{
    partial class MyPurchasesForm
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
            listViewPurchases = new ListView();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buyPhonesToolStripMenuItem = new ToolStripMenuItem();
            sellPhonesToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            logOutButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewPurchases
            // 
            listViewPurchases.Location = new Point(12, 66);
            listViewPurchases.Name = "listViewPurchases";
            listViewPurchases.Size = new Size(776, 372);
            listViewPurchases.TabIndex = 0;
            listViewPurchases.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, buyPhonesToolStripMenuItem, sellPhonesToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
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
            // sellPhonesToolStripMenuItem
            // 
            sellPhonesToolStripMenuItem.Name = "sellPhonesToolStripMenuItem";
            sellPhonesToolStripMenuItem.Size = new Size(79, 20);
            sellPhonesToolStripMenuItem.Text = "Sell Phones";
            sellPhonesToolStripMenuItem.Click += sellPhonesToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(53, 20);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // logOutButton
            // 
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.ForeColor = SystemColors.ButtonHighlight;
            logOutButton.Location = new Point(713, 0);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "button1";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // MyPurchasesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logOutButton);
            Controls.Add(listViewPurchases);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MyPurchasesForm";
            Text = "MyPurchasesForm";
            Load += MyPurchasesForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewPurchases;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem buyPhonesToolStripMenuItem;
        private ToolStripMenuItem sellPhonesToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Button logOutButton;
    }
}