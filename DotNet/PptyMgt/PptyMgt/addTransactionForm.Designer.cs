namespace PptyMgt
{
    partial class addTransactionForm
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
            cmbTransactionType = new ComboBox();
            amtLabel = new Label();
            transLabel = new Label();
            dateLabel = new Label();
            ownerIdLabel = new Label();
            PptyIdLabel = new Label();
            btnSave = new Button();
            dateTransaction = new DateTimePicker();
            txtAmount = new TextBox();
            btnCancel = new Button();
            cmbPropertyID = new ComboBox();
            cmbOwnerID = new ComboBox();
            SuspendLayout();
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Location = new Point(107, 218);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(189, 23);
            cmbTransactionType.TabIndex = 26;
            // 
            // amtLabel
            // 
            amtLabel.AutoSize = true;
            amtLabel.Location = new Point(302, 199);
            amtLabel.Name = "amtLabel";
            amtLabel.Size = new Size(38, 15);
            amtLabel.TabIndex = 25;
            amtLabel.Text = "label5";
            // 
            // transLabel
            // 
            transLabel.AutoSize = true;
            transLabel.Location = new Point(107, 199);
            transLabel.Name = "transLabel";
            transLabel.Size = new Size(38, 15);
            transLabel.TabIndex = 24;
            transLabel.Text = "label4";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(497, 143);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(38, 15);
            dateLabel.TabIndex = 23;
            dateLabel.Text = "label3";
            // 
            // ownerIdLabel
            // 
            ownerIdLabel.AutoSize = true;
            ownerIdLabel.Location = new Point(302, 143);
            ownerIdLabel.Name = "ownerIdLabel";
            ownerIdLabel.Size = new Size(38, 15);
            ownerIdLabel.TabIndex = 22;
            ownerIdLabel.Text = "label2";
            // 
            // PptyIdLabel
            // 
            PptyIdLabel.AutoSize = true;
            PptyIdLabel.Location = new Point(107, 143);
            PptyIdLabel.Name = "PptyIdLabel";
            PptyIdLabel.Size = new Size(38, 15);
            PptyIdLabel.TabIndex = 21;
            PptyIdLabel.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(162, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "button2";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTransaction
            // 
            dateTransaction.Location = new Point(497, 161);
            dateTransaction.Name = "dateTransaction";
            dateTransaction.Size = new Size(189, 23);
            dateTransaction.TabIndex = 19;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(302, 217);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(189, 23);
            txtAmount.TabIndex = 18;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(331, 246);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 23);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "button2";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbPropertyID
            // 
            cmbPropertyID.FormattingEnabled = true;
            cmbPropertyID.Location = new Point(107, 161);
            cmbPropertyID.Name = "cmbPropertyID";
            cmbPropertyID.Size = new Size(189, 23);
            cmbPropertyID.TabIndex = 28;
            // 
            // cmbOwnerID
            // 
            cmbOwnerID.FormattingEnabled = true;
            cmbOwnerID.Location = new Point(302, 161);
            cmbOwnerID.Name = "cmbOwnerID";
            cmbOwnerID.Size = new Size(189, 23);
            cmbOwnerID.TabIndex = 29;
            // 
            // addTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbOwnerID);
            Controls.Add(cmbPropertyID);
            Controls.Add(btnCancel);
            Controls.Add(cmbTransactionType);
            Controls.Add(amtLabel);
            Controls.Add(transLabel);
            Controls.Add(dateLabel);
            Controls.Add(ownerIdLabel);
            Controls.Add(PptyIdLabel);
            Controls.Add(btnSave);
            Controls.Add(dateTransaction);
            Controls.Add(txtAmount);
            Name = "addTransactionForm";
            Text = "addTransactionForm";
            Load += addTransactionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTransactionType;
        private Label amtLabel;
        private Label transLabel;
        private Label dateLabel;
        private Label ownerIdLabel;
        private Label PptyIdLabel;
        private Button btnSave;
        private DateTimePicker dateTransaction;
        private TextBox txtAmount;
        private Button btnCancel;
        private ComboBox cmbPropertyID;
        private ComboBox cmbOwnerID;
    }
}