namespace Eshop
{
    partial class OrderForm
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
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RequiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RequiredDateLabel = new System.Windows.Forms.Label();
            this.ShippingDateLabel = new System.Windows.Forms.Label();
            this.ShippingDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FreightLlabel = new System.Windows.Forms.Label();
            this.FreightTextBox = new System.Windows.Forms.TextBox();
            this.ShipNameLabel = new System.Windows.Forms.Label();
            this.ShipNameTextBox = new System.Windows.Forms.TextBox();
            this.ShipAddressTextBox = new System.Windows.Forms.TextBox();
            this.ShipAddressLabel = new System.Windows.Forms.Label();
            this.ShipCityLabel = new System.Windows.Forms.Label();
            this.ShipCityTextBox = new System.Windows.Forms.TextBox();
            this.ShipRegionLabel = new System.Windows.Forms.Label();
            this.ShipRegionTextBox = new System.Windows.Forms.TextBox();
            this.ShipPostalCodeLabel = new System.Windows.Forms.Label();
            this.ShipPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.ShipCountryLabel = new System.Windows.Forms.Label();
            this.ShipCountryTextBox = new System.Windows.Forms.TextBox();
            this.tabOrder = new System.Windows.Forms.TabControl();
            this.tabHeader = new System.Windows.Forms.TabPage();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.ChangeCompanyNameButton = new System.Windows.Forms.Button();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.tabList = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabOrder.SuspendLayout();
            this.tabHeader.SuspendLayout();
            this.tabList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(37, 109);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(59, 13);
            this.OrderDateLabel.TabIndex = 0;
            this.OrderDateLabel.Text = "Order Date";
            // 
            // OrderDateDateTimePicker
            // 
            this.OrderDateDateTimePicker.Location = new System.Drawing.Point(140, 108);
            this.OrderDateDateTimePicker.Name = "OrderDateDateTimePicker";
            this.OrderDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.OrderDateDateTimePicker.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(411, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(542, 15);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RequiredDateDateTimePicker
            // 
            this.RequiredDateDateTimePicker.Location = new System.Drawing.Point(140, 149);
            this.RequiredDateDateTimePicker.Name = "RequiredDateDateTimePicker";
            this.RequiredDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.RequiredDateDateTimePicker.TabIndex = 4;
            // 
            // RequiredDateLabel
            // 
            this.RequiredDateLabel.AutoSize = true;
            this.RequiredDateLabel.Location = new System.Drawing.Point(37, 155);
            this.RequiredDateLabel.Name = "RequiredDateLabel";
            this.RequiredDateLabel.Size = new System.Drawing.Size(76, 13);
            this.RequiredDateLabel.TabIndex = 5;
            this.RequiredDateLabel.Text = "Required Date";
            // 
            // ShippingDateLabel
            // 
            this.ShippingDateLabel.AutoSize = true;
            this.ShippingDateLabel.Location = new System.Drawing.Point(37, 198);
            this.ShippingDateLabel.Name = "ShippingDateLabel";
            this.ShippingDateLabel.Size = new System.Drawing.Size(74, 13);
            this.ShippingDateLabel.TabIndex = 6;
            this.ShippingDateLabel.Text = "Shipping Date";
            // 
            // ShippingDateDateTimePicker
            // 
            this.ShippingDateDateTimePicker.Location = new System.Drawing.Point(140, 190);
            this.ShippingDateDateTimePicker.Name = "ShippingDateDateTimePicker";
            this.ShippingDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ShippingDateDateTimePicker.TabIndex = 7;
            // 
            // FreightLlabel
            // 
            this.FreightLlabel.AutoSize = true;
            this.FreightLlabel.Location = new System.Drawing.Point(37, 237);
            this.FreightLlabel.Name = "FreightLlabel";
            this.FreightLlabel.Size = new System.Drawing.Size(39, 13);
            this.FreightLlabel.TabIndex = 8;
            this.FreightLlabel.Text = "Freight";
            // 
            // FreightTextBox
            // 
            this.FreightTextBox.Location = new System.Drawing.Point(140, 237);
            this.FreightTextBox.Name = "FreightTextBox";
            this.FreightTextBox.Size = new System.Drawing.Size(100, 20);
            this.FreightTextBox.TabIndex = 9;
            // 
            // ShipNameLabel
            // 
            this.ShipNameLabel.AutoSize = true;
            this.ShipNameLabel.Location = new System.Drawing.Point(37, 281);
            this.ShipNameLabel.Name = "ShipNameLabel";
            this.ShipNameLabel.Size = new System.Drawing.Size(59, 13);
            this.ShipNameLabel.TabIndex = 10;
            this.ShipNameLabel.Text = "Ship Name";
            // 
            // ShipNameTextBox
            // 
            this.ShipNameTextBox.Location = new System.Drawing.Point(140, 281);
            this.ShipNameTextBox.Name = "ShipNameTextBox";
            this.ShipNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipNameTextBox.TabIndex = 11;
            // 
            // ShipAddressTextBox
            // 
            this.ShipAddressTextBox.Location = new System.Drawing.Point(140, 326);
            this.ShipAddressTextBox.Name = "ShipAddressTextBox";
            this.ShipAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipAddressTextBox.TabIndex = 13;
            // 
            // ShipAddressLabel
            // 
            this.ShipAddressLabel.AutoSize = true;
            this.ShipAddressLabel.Location = new System.Drawing.Point(37, 326);
            this.ShipAddressLabel.Name = "ShipAddressLabel";
            this.ShipAddressLabel.Size = new System.Drawing.Size(69, 13);
            this.ShipAddressLabel.TabIndex = 12;
            this.ShipAddressLabel.Text = "Ship Address";
            // 
            // ShipCityLabel
            // 
            this.ShipCityLabel.AutoSize = true;
            this.ShipCityLabel.Location = new System.Drawing.Point(37, 370);
            this.ShipCityLabel.Name = "ShipCityLabel";
            this.ShipCityLabel.Size = new System.Drawing.Size(48, 13);
            this.ShipCityLabel.TabIndex = 10;
            this.ShipCityLabel.Text = "Ship City";
            // 
            // ShipCityTextBox
            // 
            this.ShipCityTextBox.Location = new System.Drawing.Point(140, 367);
            this.ShipCityTextBox.Name = "ShipCityTextBox";
            this.ShipCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipCityTextBox.TabIndex = 11;
            // 
            // ShipRegionLabel
            // 
            this.ShipRegionLabel.AutoSize = true;
            this.ShipRegionLabel.Location = new System.Drawing.Point(37, 415);
            this.ShipRegionLabel.Name = "ShipRegionLabel";
            this.ShipRegionLabel.Size = new System.Drawing.Size(65, 13);
            this.ShipRegionLabel.TabIndex = 12;
            this.ShipRegionLabel.Text = "Ship Region";
            // 
            // ShipRegionTextBox
            // 
            this.ShipRegionTextBox.Location = new System.Drawing.Point(140, 408);
            this.ShipRegionTextBox.Name = "ShipRegionTextBox";
            this.ShipRegionTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipRegionTextBox.TabIndex = 13;
            // 
            // ShipPostalCodeLabel
            // 
            this.ShipPostalCodeLabel.AutoSize = true;
            this.ShipPostalCodeLabel.Location = new System.Drawing.Point(37, 453);
            this.ShipPostalCodeLabel.Name = "ShipPostalCodeLabel";
            this.ShipPostalCodeLabel.Size = new System.Drawing.Size(88, 13);
            this.ShipPostalCodeLabel.TabIndex = 10;
            this.ShipPostalCodeLabel.Text = "Ship Postal Code";
            // 
            // ShipPostalCodeTextBox
            // 
            this.ShipPostalCodeTextBox.Location = new System.Drawing.Point(140, 446);
            this.ShipPostalCodeTextBox.Name = "ShipPostalCodeTextBox";
            this.ShipPostalCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipPostalCodeTextBox.TabIndex = 11;
            // 
            // ShipCountryLabel
            // 
            this.ShipCountryLabel.AutoSize = true;
            this.ShipCountryLabel.Location = new System.Drawing.Point(37, 491);
            this.ShipCountryLabel.Name = "ShipCountryLabel";
            this.ShipCountryLabel.Size = new System.Drawing.Size(67, 13);
            this.ShipCountryLabel.TabIndex = 12;
            this.ShipCountryLabel.Text = "Ship Country";
            // 
            // ShipCountryTextBox
            // 
            this.ShipCountryTextBox.Location = new System.Drawing.Point(140, 484);
            this.ShipCountryTextBox.Name = "ShipCountryTextBox";
            this.ShipCountryTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShipCountryTextBox.TabIndex = 13;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.tabHeader);
            this.tabOrder.Controls.Add(this.tabList);
            this.tabOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOrder.Location = new System.Drawing.Point(0, 0);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.SelectedIndex = 0;
            this.tabOrder.Size = new System.Drawing.Size(638, 592);
            this.tabOrder.TabIndex = 14;
            // 
            // tabHeader
            // 
            this.tabHeader.Controls.Add(this.OrderNumberLabel);
            this.tabHeader.Controls.Add(this.OrderNumberTextBox);
            this.tabHeader.Controls.Add(this.ChangeCompanyNameButton);
            this.tabHeader.Controls.Add(this.CompanyNameLabel);
            this.tabHeader.Controls.Add(this.CompanyNameTextBox);
            this.tabHeader.Controls.Add(this.ShipAddressLabel);
            this.tabHeader.Controls.Add(this.OrderDateLabel);
            this.tabHeader.Controls.Add(this.ShipCountryTextBox);
            this.tabHeader.Controls.Add(this.OrderDateDateTimePicker);
            this.tabHeader.Controls.Add(this.ShipCountryLabel);
            this.tabHeader.Controls.Add(this.RequiredDateDateTimePicker);
            this.tabHeader.Controls.Add(this.ShipRegionTextBox);
            this.tabHeader.Controls.Add(this.RequiredDateLabel);
            this.tabHeader.Controls.Add(this.ShipRegionLabel);
            this.tabHeader.Controls.Add(this.ShippingDateLabel);
            this.tabHeader.Controls.Add(this.ShipPostalCodeTextBox);
            this.tabHeader.Controls.Add(this.ShippingDateDateTimePicker);
            this.tabHeader.Controls.Add(this.ShipAddressTextBox);
            this.tabHeader.Controls.Add(this.FreightLlabel);
            this.tabHeader.Controls.Add(this.ShipCityTextBox);
            this.tabHeader.Controls.Add(this.FreightTextBox);
            this.tabHeader.Controls.Add(this.ShipPostalCodeLabel);
            this.tabHeader.Controls.Add(this.ShipNameLabel);
            this.tabHeader.Controls.Add(this.ShipNameTextBox);
            this.tabHeader.Controls.Add(this.ShipCityLabel);
            this.tabHeader.Location = new System.Drawing.Point(4, 22);
            this.tabHeader.Name = "tabHeader";
            this.tabHeader.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeader.Size = new System.Drawing.Size(630, 566);
            this.tabHeader.TabIndex = 0;
            this.tabHeader.Text = "Header";
            this.tabHeader.UseVisualStyleBackColor = true;
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Location = new System.Drawing.Point(37, 19);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(73, 13);
            this.OrderNumberLabel.TabIndex = 17;
            this.OrderNumberLabel.Text = "Order Number";
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(140, 19);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.ReadOnly = true;
            this.OrderNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderNumberTextBox.TabIndex = 18;
            // 
            // ChangeCompanyNameButton
            // 
            this.ChangeCompanyNameButton.Location = new System.Drawing.Point(346, 58);
            this.ChangeCompanyNameButton.Name = "ChangeCompanyNameButton";
            this.ChangeCompanyNameButton.Size = new System.Drawing.Size(90, 28);
            this.ChangeCompanyNameButton.TabIndex = 16;
            this.ChangeCompanyNameButton.Text = "Change";
            this.ChangeCompanyNameButton.UseVisualStyleBackColor = true;
            this.ChangeCompanyNameButton.Click += new System.EventHandler(this.ChangeCompanyNameButton_Click);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Location = new System.Drawing.Point(37, 66);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(79, 13);
            this.CompanyNameLabel.TabIndex = 14;
            this.CompanyNameLabel.Text = "CompanyName";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(140, 63);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.ReadOnly = true;
            this.CompanyNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.CompanyNameTextBox.TabIndex = 15;
            this.CompanyNameTextBox.DoubleClick += new System.EventHandler(this.CompanyNameTextBox_DoubleClick);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dataGridView1);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(630, 566);
            this.tabList.TabIndex = 1;
            this.tabList.Text = "List of Items";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 560);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 50);
            this.panel1.TabIndex = 15;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 642);
            this.Controls.Add(this.tabOrder);
            this.Controls.Add(this.panel1);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.tabOrder.ResumeLayout(false);
            this.tabHeader.ResumeLayout(false);
            this.tabHeader.PerformLayout();
            this.tabList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label RequiredDateLabel;
        private System.Windows.Forms.Label ShippingDateLabel;
        private System.Windows.Forms.Label FreightLlabel;
        private System.Windows.Forms.Label ShipNameLabel;
        private System.Windows.Forms.Label ShipAddressLabel;
        private System.Windows.Forms.Label ShipCityLabel;
        private System.Windows.Forms.Label ShipRegionLabel;
        private System.Windows.Forms.Label ShipPostalCodeLabel;
        private System.Windows.Forms.Label ShipCountryLabel;
        public System.Windows.Forms.DateTimePicker OrderDateDateTimePicker;
        public System.Windows.Forms.DateTimePicker RequiredDateDateTimePicker;
        public System.Windows.Forms.DateTimePicker ShippingDateDateTimePicker;
        public System.Windows.Forms.TextBox FreightTextBox;
        public System.Windows.Forms.TextBox ShipNameTextBox;
        public System.Windows.Forms.TextBox ShipAddressTextBox;
        public System.Windows.Forms.TextBox ShipCityTextBox;
        public System.Windows.Forms.TextBox ShipRegionTextBox;
        public System.Windows.Forms.TextBox ShipPostalCodeTextBox;
        public System.Windows.Forms.TextBox ShipCountryTextBox;
        private System.Windows.Forms.TabControl tabOrder;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangeCompanyNameButton;
        private System.Windows.Forms.Label CompanyNameLabel;
        public System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label OrderNumberLabel;
        public System.Windows.Forms.TextBox OrderNumberTextBox;
    }
}