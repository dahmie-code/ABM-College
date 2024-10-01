namespace PptyMgt
{
    partial class TransactionManagement
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
            txtPropertyID = new TextBox();
            txtOwnerID = new TextBox();
            dateStartDate = new DateTimePicker();
            btnAddTransaction = new Button();
            btnFilter = new Button();
            btnRefresh = new Button();
            dataGridViewTransactions = new DataGridView();
            PptyIdLabel = new Label();
            ownerIdLabel = new Label();
            startDateLabel = new Label();
            transLabel = new Label();
            cmbTransactionType = new ComboBox();
            endDateLabel = new Label();
            dateEndDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // txtPropertyID
            // 
            txtPropertyID.Location = new Point(12, 33);
            txtPropertyID.Name = "txtPropertyID";
            txtPropertyID.Size = new Size(189, 23);
            txtPropertyID.TabIndex = 0;
            // 
            // txtOwnerID
            // 
            txtOwnerID.Location = new Point(207, 33);
            txtOwnerID.Name = "txtOwnerID";
            txtOwnerID.Size = new Size(189, 23);
            txtOwnerID.TabIndex = 1;
            // 
            // dateStartDate
            // 
            dateStartDate.Location = new Point(12, 83);
            dateStartDate.Name = "dateStartDate";
            dateStartDate.Size = new Size(189, 23);
            dateStartDate.TabIndex = 4;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Location = new Point(12, 415);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(110, 23);
            btnAddTransaction.TabIndex = 5;
            btnAddTransaction.Text = "button1";
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(402, 83);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(99, 23);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "button2";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(128, 415);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 23);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "button3";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(12, 114);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.RowTemplate.Height = 25;
            dataGridViewTransactions.Size = new Size(776, 295);
            dataGridViewTransactions.TabIndex = 9;
            // 
            // PptyIdLabel
            // 
            PptyIdLabel.AutoSize = true;
            PptyIdLabel.Location = new Point(12, 15);
            PptyIdLabel.Name = "PptyIdLabel";
            PptyIdLabel.Size = new Size(38, 15);
            PptyIdLabel.TabIndex = 10;
            PptyIdLabel.Text = "label1";
            // 
            // ownerIdLabel
            // 
            ownerIdLabel.AutoSize = true;
            ownerIdLabel.Location = new Point(207, 15);
            ownerIdLabel.Name = "ownerIdLabel";
            ownerIdLabel.Size = new Size(38, 15);
            ownerIdLabel.TabIndex = 11;
            ownerIdLabel.Text = "label2";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(12, 65);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(38, 15);
            startDateLabel.TabIndex = 12;
            startDateLabel.Text = "label3";
            // 
            // transLabel
            // 
            transLabel.AutoSize = true;
            transLabel.Location = new Point(402, 14);
            transLabel.Name = "transLabel";
            transLabel.Size = new Size(38, 15);
            transLabel.TabIndex = 13;
            transLabel.Text = "label4";
            // 
            // cmbTransactionType
            // 
            cmbTransactionType.FormattingEnabled = true;
            cmbTransactionType.Location = new Point(402, 33);
            cmbTransactionType.Name = "cmbTransactionType";
            cmbTransactionType.Size = new Size(189, 23);
            cmbTransactionType.TabIndex = 15;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(207, 63);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(38, 15);
            endDateLabel.TabIndex = 16;
            endDateLabel.Text = "label3";
            // 
            // dateEndDate
            // 
            dateEndDate.Location = new Point(207, 83);
            dateEndDate.Name = "dateEndDate";
            dateEndDate.Size = new Size(189, 23);
            dateEndDate.TabIndex = 17;
            // 
            // TransactionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateEndDate);
            Controls.Add(endDateLabel);
            Controls.Add(cmbTransactionType);
            Controls.Add(transLabel);
            Controls.Add(startDateLabel);
            Controls.Add(ownerIdLabel);
            Controls.Add(PptyIdLabel);
            Controls.Add(dataGridViewTransactions);
            Controls.Add(btnRefresh);
            Controls.Add(btnFilter);
            Controls.Add(btnAddTransaction);
            Controls.Add(dateStartDate);
            Controls.Add(txtOwnerID);
            Controls.Add(txtPropertyID);
            Name = "TransactionManagement";
            Text = "TransactionManagement";
            Load += TransactionManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPropertyID;
        private TextBox txtOwnerID;
        private DateTimePicker dateStartDate;
        private Button btnAddTransaction;
        private Button btnFilter;
        private Button btnRefresh;
        private DataGridView dataGridViewTransactions;
        private Label PptyIdLabel;
        private Label ownerIdLabel;
        private Label startDateLabel;
        private Label transLabel;
        private ComboBox cmbTransactionType;
        private Label endDateLabel;
        private DateTimePicker dateEndDate;
    }
}