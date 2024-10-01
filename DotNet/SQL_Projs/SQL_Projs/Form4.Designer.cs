namespace SQL_Projs
{
    partial class Form4
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
            txtBuyerId = new TextBox();
            txtProductId = new TextBox();
            txtQuantity = new TextBox();
            txtTotalPrice = new TextBox();
            btnPlaceOrder = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            updateBtn = new Button();
            label5 = new Label();
            txtOrderId = new TextBox();
            deleteBtn = new Button();
            dataGridViewOrderLog = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderLog).BeginInit();
            SuspendLayout();
            // 
            // txtBuyerId
            // 
            txtBuyerId.Location = new Point(125, 38);
            txtBuyerId.Name = "txtBuyerId";
            txtBuyerId.Size = new Size(128, 23);
            txtBuyerId.TabIndex = 0;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(125, 92);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(128, 23);
            txtProductId.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(125, 121);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(128, 23);
            txtQuantity.TabIndex = 2;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(125, 150);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(128, 23);
            txtTotalPrice.TabIndex = 3;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(125, 179);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(128, 23);
            btnPlaceOrder.TabIndex = 4;
            btnPlaceOrder.Text = "button1";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 100);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 129);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 158);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(259, 179);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(128, 23);
            updateBtn.TabIndex = 9;
            updateBtn.Text = "button1";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 72);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "label5";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(125, 64);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(128, 23);
            txtOrderId.TabIndex = 11;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(393, 179);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(128, 23);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "button1";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // dataGridViewOrderLog
            // 
            dataGridViewOrderLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderLog.Location = new Point(21, 12);
            dataGridViewOrderLog.Name = "dataGridViewOrderLog";
            dataGridViewOrderLog.RowTemplate.Height = 25;
            dataGridViewOrderLog.Size = new Size(690, 272);
            dataGridViewOrderLog.TabIndex = 13;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewOrderLog);
            Controls.Add(deleteBtn);
            Controls.Add(txtOrderId);
            Controls.Add(label5);
            Controls.Add(updateBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPlaceOrder);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtProductId);
            Controls.Add(txtBuyerId);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuyerId;
        private TextBox txtProductId;
        private TextBox txtQuantity;
        private TextBox txtTotalPrice;
        private Button btnPlaceOrder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button updateBtn;
        private Label label5;
        private TextBox txtOrderId;
        private Button deleteBtn;
        private DataGridView dataGridViewOrderLog;
    }
}