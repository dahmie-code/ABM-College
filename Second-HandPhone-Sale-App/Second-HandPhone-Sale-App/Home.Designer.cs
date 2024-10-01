namespace Second_HandPhone_Sale_App
{
    partial class Home
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
            welcomeLabel = new Label();
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            buyPhonesToolStripMenuItem = new ToolStripMenuItem();
            sellPhonesToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            logOutButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            usedNewlabel = new Label();
            usedGoodlabel = new Label();
            fairlyUsedLabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Roboto Medium", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(786, 5);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(45, 14);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "label1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, buyPhonesToolStripMenuItem, sellPhonesToolStripMenuItem, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1041, 24);
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
            logOutButton.FlatStyle = FlatStyle.Popup;
            logOutButton.ForeColor = SystemColors.ButtonHighlight;
            logOutButton.Location = new Point(931, 1);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "button1";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.amjith_s_yMubHZhtvas_unsplash;
            pictureBox1.Location = new Point(24, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 403);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.zeesha_SUGIhq_GrIs_unsplash;
            pictureBox2.Location = new Point(379, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(286, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.evgeny_opanasenko_KMIlGDfC0YY_unsplash;
            pictureBox3.Location = new Point(722, 65);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(286, 403);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // usedNewlabel
            // 
            usedNewlabel.AutoSize = true;
            usedNewlabel.BackColor = SystemColors.ActiveCaptionText;
            usedNewlabel.Cursor = Cursors.Hand;
            usedNewlabel.Font = new Font("Roboto Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usedNewlabel.ForeColor = SystemColors.ButtonHighlight;
            usedNewlabel.Location = new Point(106, 408);
            usedNewlabel.Name = "usedNewlabel";
            usedNewlabel.Padding = new Padding(2);
            usedNewlabel.Size = new Size(51, 19);
            usedNewlabel.TabIndex = 6;
            usedNewlabel.Text = "label1";
            usedNewlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usedGoodlabel
            // 
            usedGoodlabel.AutoSize = true;
            usedGoodlabel.BackColor = SystemColors.ActiveCaptionText;
            usedGoodlabel.Font = new Font("Roboto Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            usedGoodlabel.ForeColor = SystemColors.ButtonHighlight;
            usedGoodlabel.Location = new Point(419, 408);
            usedGoodlabel.Name = "usedGoodlabel";
            usedGoodlabel.Padding = new Padding(2);
            usedGoodlabel.Size = new Size(51, 19);
            usedGoodlabel.TabIndex = 7;
            usedGoodlabel.Text = "label1";
            usedGoodlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fairlyUsedLabel
            // 
            fairlyUsedLabel.AutoSize = true;
            fairlyUsedLabel.BackColor = SystemColors.ActiveCaptionText;
            fairlyUsedLabel.Font = new Font("Roboto Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fairlyUsedLabel.ForeColor = SystemColors.ButtonHighlight;
            fairlyUsedLabel.Location = new Point(805, 408);
            fairlyUsedLabel.Name = "fairlyUsedLabel";
            fairlyUsedLabel.Padding = new Padding(2);
            fairlyUsedLabel.Size = new Size(51, 19);
            fairlyUsedLabel.TabIndex = 8;
            fairlyUsedLabel.Text = "label1";
            fairlyUsedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 513);
            Controls.Add(fairlyUsedLabel);
            Controls.Add(usedGoodlabel);
            Controls.Add(usedNewlabel);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(logOutButton);
            Controls.Add(welcomeLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem buyPhonesToolStripMenuItem;
        private ToolStripMenuItem sellPhonesToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private Button logOutButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label usedNewlabel;
        private Label usedGoodlabel;
        private Label fairlyUsedLabel;
    }
}