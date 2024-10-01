namespace PptyMgt
{
    partial class FormAddProperty
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
            address = new Label();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZipCode = new TextBox();
            txtPrice = new TextBox();
            txtBedrooms = new TextBox();
            txtBathrooms = new TextBox();
            txtDescription = new TextBox();
            cmbPropertyType = new ComboBox();
            city = new Label();
            state = new Label();
            zipCode = new Label();
            price = new Label();
            typeLabel = new Label();
            Bedrooms = new Label();
            Bathrooms = new Label();
            desc = new Label();
            saveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(12, 79);
            address.Name = "address";
            address.Size = new Size(38, 15);
            address.TabIndex = 0;
            address.Text = "label1";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(135, 71);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(166, 23);
            txtAddress.TabIndex = 1;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(486, 71);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(166, 23);
            txtCity.TabIndex = 2;
            // 
            // txtState
            // 
            txtState.Location = new Point(135, 100);
            txtState.Name = "txtState";
            txtState.Size = new Size(166, 23);
            txtState.TabIndex = 3;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(486, 100);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(166, 23);
            txtZipCode.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(135, 129);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 23);
            txtPrice.TabIndex = 5;
            // 
            // txtBedrooms
            // 
            txtBedrooms.Location = new Point(135, 158);
            txtBedrooms.Name = "txtBedrooms";
            txtBedrooms.Size = new Size(166, 23);
            txtBedrooms.TabIndex = 7;
            // 
            // txtBathrooms
            // 
            txtBathrooms.Location = new Point(486, 158);
            txtBathrooms.Name = "txtBathrooms";
            txtBathrooms.Size = new Size(166, 23);
            txtBathrooms.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(135, 187);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(166, 23);
            txtDescription.TabIndex = 9;
            // 
            // cmbPropertyType
            // 
            cmbPropertyType.FormattingEnabled = true;
            cmbPropertyType.Location = new Point(486, 129);
            cmbPropertyType.Name = "cmbPropertyType";
            cmbPropertyType.Size = new Size(166, 23);
            cmbPropertyType.TabIndex = 10;
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(368, 79);
            city.Name = "city";
            city.Size = new Size(38, 15);
            city.TabIndex = 11;
            city.Text = "label2";
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(12, 108);
            state.Name = "state";
            state.Size = new Size(38, 15);
            state.TabIndex = 12;
            state.Text = "label3";
            // 
            // zipCode
            // 
            zipCode.AutoSize = true;
            zipCode.Location = new Point(368, 108);
            zipCode.Name = "zipCode";
            zipCode.Size = new Size(38, 15);
            zipCode.TabIndex = 13;
            zipCode.Text = "label4";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(12, 137);
            price.Name = "price";
            price.Size = new Size(38, 15);
            price.TabIndex = 14;
            price.Text = "label5";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(368, 137);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(38, 15);
            typeLabel.TabIndex = 15;
            typeLabel.Text = "label6";
            // 
            // Bedrooms
            // 
            Bedrooms.AutoSize = true;
            Bedrooms.Location = new Point(12, 166);
            Bedrooms.Name = "Bedrooms";
            Bedrooms.Size = new Size(38, 15);
            Bedrooms.TabIndex = 16;
            Bedrooms.Text = "label7";
            // 
            // Bathrooms
            // 
            Bathrooms.AutoSize = true;
            Bathrooms.Location = new Point(368, 166);
            Bathrooms.Name = "Bathrooms";
            Bathrooms.Size = new Size(38, 15);
            Bathrooms.TabIndex = 17;
            Bathrooms.Text = "label8";
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Location = new Point(12, 195);
            desc.Name = "desc";
            desc.Size = new Size(38, 15);
            desc.TabIndex = 18;
            desc.Text = "label9";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(236, 256);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 19;
            saveBtn.Text = "button1";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(405, 256);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 20;
            cancelBtn.Text = "button2";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // FormAddProperty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(desc);
            Controls.Add(Bathrooms);
            Controls.Add(Bedrooms);
            Controls.Add(typeLabel);
            Controls.Add(price);
            Controls.Add(zipCode);
            Controls.Add(state);
            Controls.Add(city);
            Controls.Add(cmbPropertyType);
            Controls.Add(txtDescription);
            Controls.Add(txtBathrooms);
            Controls.Add(txtBedrooms);
            Controls.Add(txtPrice);
            Controls.Add(txtZipCode);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(address);
            Name = "FormAddProperty";
            Text = "FormAddProperty";
            Load += FormAddProperty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label address;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZipCode;
        private TextBox txtPrice;
        private TextBox txtBedrooms;
        private TextBox txtBathrooms;
        private TextBox txtDescription;
        private ComboBox cmbPropertyType;
        private Label city;
        private Label state;
        private Label zipCode;
        private Label price;
        private Label typeLabel;
        private Label Bedrooms;
        private Label Bathrooms;
        private Label desc;
        private Button saveBtn;
        private Button cancelBtn;
    }
}