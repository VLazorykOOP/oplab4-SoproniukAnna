using System;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AddForm : Form
    {
        public string Type { get; private set; }
        public string Brand { get; private set; }
        public string Manufacturer { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public string Supplier { get; private set; }
        public decimal Price { get; private set; }

        public AddForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Type = typeTextBox.Text;
            Brand = brandTextBox.Text;
            Manufacturer = manufacturerTextBox.Text;
            ExpiryDate = expiryDatePicker.Value;
            Supplier = supplierTextBox.Text;
            Price = decimal.Parse(priceTextBox.Text);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
