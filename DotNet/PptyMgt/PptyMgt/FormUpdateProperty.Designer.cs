namespace PptyMgt
{
    partial class FormUpdateProperty
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
            cancelBtn = new Button();
            saveBtn = new Button();
            desc = new Label();
            Bathrooms = new Label();
            Bedrooms = new Label();
            typeLabel = new Label();
            price = new Label();
            zipCode = new Label();
            state = new Label();
            city = new Label();
            cmbPropertyType = new ComboBox();
            txtDescription = new TextBox();
            txtBathrooms = new TextBox();
            txtBedrooms = new TextBox();
            txtPrice = new TextBox();
            txtZipCode = new TextBox();
            txtState = new TextBox();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            address = new Label();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(435, 268);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 40;
            cancelBtn.Text = "button2";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(266, 268);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 39;
            saveBtn.Text = "button1";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // desc
            // 
            desc.AutoSize = true;
            desc.Location = new Point(42, 207);
            desc.Name = "desc";
            desc.Size = new Size(38, 15);
            desc.TabIndex = 38;
            desc.Text = "label9";
            // 
            // Bathrooms
            // 
            Bathrooms.AutoSize = true;
            Bathrooms.Location = new Point(398, 178);
            Bathrooms.Name = "Bathrooms";
            Bathrooms.Size = new Size(38, 15);
            Bathrooms.TabIndex = 37;
            Bathrooms.Text = "label8";
            // 
            // Bedrooms
            // 
            Bedrooms.AutoSize = true;
            Bedrooms.Location = new Point(42, 178);
            Bedrooms.Name = "Bedrooms";
            Bedrooms.Size = new Size(38, 15);
            Bedrooms.TabIndex = 36;
            Bedrooms.Text = "label7";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(398, 149);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(38, 15);
            typeLabel.TabIndex = 35;
            typeLabel.Text = "label6";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(42, 149);
            price.Name = "price";
            price.Size = new Size(38, 15);
            price.TabIndex = 34;
            price.Text = "label5";
            // 
            // zipCode
            // 
            zipCode.AutoSize = true;
            zipCode.Location = new Point(398, 120);
            zipCode.Name = "zipCode";
            zipCode.Size = new Size(38, 15);
            zipCode.TabIndex = 33;
            zipCode.Text = "label4";
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(42, 120);
            state.Name = "state";
            state.Size = new Size(38, 15);
            state.TabIndex = 32;
            state.Text = "label3";
            // 
            // city
            // 
            city.AutoSize = true;
            city.Location = new Point(398, 91);
            city.Name = "city";
            city.Size = new Size(38, 15);
            city.TabIndex = 31;
            city.Text = "label2";
            // 
            // cmbPropertyType
            // 
            cmbPropertyType.FormattingEnabled = true;
            cmbPropertyType.Location = new Point(516, 141);
            cmbPropertyType.Name = "cmbPropertyType";
            cmbPropertyType.Size = new Size(166, 23);
            cmbPropertyType.TabIndex = 30;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(165, 199);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(166, 23);
            txtDescription.TabIndex = 29;
            // 
            // txtBathrooms
            // 
            txtBathrooms.Location = new Point(516, 170);
            txtBathrooms.Name = "txtBathrooms";
            txtBathrooms.Size = new Size(166, 23);
            txtBathrooms.TabIndex = 28;
            // 
            // txtBedrooms
            // 
            txtBedrooms.Location = new Point(165, 170);
            txtBedrooms.Name = "txtBedrooms";
            txtBedrooms.Size = new Size(166, 23);
            txtBedrooms.TabIndex = 27;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(165, 141);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 23);
            txtPrice.TabIndex = 26;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(516, 112);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(166, 23);
            txtZipCode.TabIndex = 25;
            // 
            // txtState
            // 
            txtState.Location = new Point(165, 112);
            txtState.Name = "txtState";
            txtState.Size = new Size(166, 23);
            txtState.TabIndex = 24;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(516, 83);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(166, 23);
            txtCity.TabIndex = 23;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(165, 83);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(166, 23);
            txtAddress.TabIndex = 22;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Location = new Point(42, 91);
            address.Name = "address";
            address.Size = new Size(38, 15);
            address.TabIndex = 21;
            address.Text = "label1";
            // 
            // FormUpdateProperty
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
            Name = "FormUpdateProperty";
            Text = "FormUpdateProperty";
            Load += FormUpdateProperty_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private Label desc;
        private Label Bathrooms;
        private Label Bedrooms;
        private Label typeLabel;
        private Label price;
        private Label zipCode;
        private Label state;
        private Label city;
        private ComboBox cmbPropertyType;
        private TextBox txtDescription;
        private TextBox txtBathrooms;
        private TextBox txtBedrooms;
        private TextBox txtPrice;
        private TextBox txtZipCode;
        private TextBox txtState;
        private TextBox txtCity;
        private TextBox txtAddress;
        private Label address;
    }
}