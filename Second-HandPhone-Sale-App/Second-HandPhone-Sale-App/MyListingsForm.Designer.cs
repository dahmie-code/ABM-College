namespace Second_HandPhone_Sale_App
{
    partial class MyListingsForm
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
            dataGridViewListings = new DataGridView();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buyPhonesToolStripMenuItem = new ToolStripMenuItem();
            sellPhonesToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            logOutButton = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListings).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewListings
            // 
            dataGridViewListings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListings.Location = new Point(12, 50);
            dataGridViewListings.Name = "dataGridViewListings";
            dataGridViewListings.RowTemplate.Height = 25;
            dataGridViewListings.Size = new Size(776, 325);
            dataGridViewListings.TabIndex = 0;
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
            logOutButton.Location = new Point(713, 2);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "button1";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(166, 399);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(305, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(441, 399);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "button3";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // MyListingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(logOutButton);
            Controls.Add(dataGridViewListings);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MyListingsForm";
            Text = "MyListingsForm";
            Load += MyListingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListings).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewListings;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private Button logOutButton;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private ToolStripMenuItem buyPhonesToolStripMenuItem;
        private ToolStripMenuItem sellPhonesToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
    }
}