namespace Second_HandPhone_Sale_App
{
    partial class Buy
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            sellPhonesToolStripMenuItem = new ToolStripMenuItem();
            myPurchasesToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            logOutButton = new Button();
            listView1 = new ListView();
            comboBoxBrand = new ComboBox();
            comboBoxPriceRange = new ComboBox();
            comboBoxCondition = new ComboBox();
            searchBar = new TextBox();
            checkOutButton = new Button();
            buttonBuyNow = new Button();
            labelNoResults = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, sellPhonesToolStripMenuItem, myPurchasesToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1037, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // sellPhonesToolStripMenuItem
            // 
            sellPhonesToolStripMenuItem.Name = "sellPhonesToolStripMenuItem";
            sellPhonesToolStripMenuItem.Size = new Size(79, 20);
            sellPhonesToolStripMenuItem.Text = "Sell Phones";
            sellPhonesToolStripMenuItem.Click += sellPhonesToolStripMenuItem_Click;
            // 
            // myPurchasesToolStripMenuItem
            // 
            myPurchasesToolStripMenuItem.Name = "myPurchasesToolStripMenuItem";
            myPurchasesToolStripMenuItem.Size = new Size(92, 20);
            myPurchasesToolStripMenuItem.Text = "My Purchases";
            myPurchasesToolStripMenuItem.Click += myPurchasesToolStripMenuItem_Click;
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
            logOutButton.Font = new Font("Roboto Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.ForeColor = SystemColors.ControlLightLight;
            logOutButton.Location = new Point(950, 2);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 1;
            logOutButton.Text = "button1";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click_1;
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(12, 100);
            listView1.Name = "listView1";
            listView1.Size = new Size(1013, 438);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(649, 45);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(122, 23);
            comboBoxBrand.TabIndex = 3;
            // 
            // comboBoxPriceRange
            // 
            comboBoxPriceRange.FormattingEnabled = true;
            comboBoxPriceRange.Location = new Point(776, 45);
            comboBoxPriceRange.Name = "comboBoxPriceRange";
            comboBoxPriceRange.Size = new Size(122, 23);
            comboBoxPriceRange.TabIndex = 4;
            // 
            // comboBoxCondition
            // 
            comboBoxCondition.FormattingEnabled = true;
            comboBoxCondition.Location = new Point(903, 45);
            comboBoxCondition.Name = "comboBoxCondition";
            comboBoxCondition.Size = new Size(122, 23);
            comboBoxCondition.TabIndex = 5;
            // 
            // searchBar
            // 
            searchBar.BorderStyle = BorderStyle.FixedSingle;
            searchBar.Location = new Point(11, 45);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search for Phones";
            searchBar.Size = new Size(261, 23);
            searchBar.TabIndex = 6;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // checkOutButton
            // 
            checkOutButton.Location = new Point(951, 544);
            checkOutButton.Name = "checkOutButton";
            checkOutButton.Size = new Size(75, 23);
            checkOutButton.TabIndex = 7;
            checkOutButton.Text = "button1";
            checkOutButton.UseVisualStyleBackColor = true;
            checkOutButton.Click += checkOutButton_Click_1;
            // 
            // buttonBuyNow
            // 
            buttonBuyNow.Location = new Point(870, 544);
            buttonBuyNow.Name = "buttonBuyNow";
            buttonBuyNow.Size = new Size(75, 23);
            buttonBuyNow.TabIndex = 8;
            buttonBuyNow.Text = "button1";
            buttonBuyNow.UseVisualStyleBackColor = true;
            buttonBuyNow.Click += buttonBuyNow_Click;
            // 
            // labelNoResults
            // 
            labelNoResults.AutoSize = true;
            labelNoResults.Location = new Point(427, 247);
            labelNoResults.Name = "labelNoResults";
            labelNoResults.Size = new Size(38, 15);
            labelNoResults.TabIndex = 9;
            labelNoResults.Text = "label1";
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 572);
            Controls.Add(labelNoResults);
            Controls.Add(buttonBuyNow);
            Controls.Add(checkOutButton);
            Controls.Add(searchBar);
            Controls.Add(comboBoxCondition);
            Controls.Add(comboBoxPriceRange);
            Controls.Add(comboBoxBrand);
            Controls.Add(listView1);
            Controls.Add(logOutButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Buy";
            Text = "Buy Phones";
            Load += Buy_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem sellPhonesToolStripMenuItem;
        private ToolStripMenuItem myPurchasesToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Button logOutButton;
        private ListView listView1;
        private ComboBox comboBoxBrand;
        private ComboBox comboBoxPriceRange;
        private ComboBox comboBoxCondition;
        private TextBox searchBar;
        private Button checkOutButton;
        private Panel panelFilters;
        private Button buttonBuyNow;
        private Label labelNoResults;
    }
}