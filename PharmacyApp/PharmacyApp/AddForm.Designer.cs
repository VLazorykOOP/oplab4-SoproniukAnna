namespace PharmacyApp
{
    partial class AddForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.supplierTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(12, 12);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(260, 20);
            this.typeTextBox.TabIndex = 0;
            this.typeTextBox.Text = "Type";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(12, 38);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(260, 20);
            this.brandTextBox.TabIndex = 1;
            this.brandTextBox.Text = "Brand";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.Location = new System.Drawing.Point(12, 64);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(260, 20);
            this.manufacturerTextBox.TabIndex = 2;
            this.manufacturerTextBox.Text = "Manufacturer";
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Location = new System.Drawing.Point(12, 90);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(260, 20);
            this.expiryDatePicker.TabIndex = 3;
            // 
            // supplierTextBox
            // 
            this.supplierTextBox.Location = new System.Drawing.Point(12, 116);
            this.supplierTextBox.Name = "supplierTextBox";
            this.supplierTextBox.Size = new System.Drawing.Size(260, 20);
            this.supplierTextBox.TabIndex = 4;
            this.supplierTextBox.Text = "Supplier";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(12, 142);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(260, 20);
            this.priceTextBox.TabIndex = 5;
            this.priceTextBox.Text = "Price";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(197, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.supplierTextBox);
            this.Controls.Add(this.expiryDatePicker);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.typeTextBox);
            this.Name = "AddForm";
            this.Text = "Add Medication";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.DateTimePicker expiryDatePicker;
        private System.Windows.Forms.TextBox supplierTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}
