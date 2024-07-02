using System.Windows.Forms;
using System;

namespace PharmacyApp
{
    public partial class EditForm : Form
    {
        public int Id { get; private set; }
        public string Type { get; private set; }
        public string Brand { get; private set; }
        public string Manufacturer { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public string Supplier { get; private set; }
        public decimal Price { get; private set; }

        public EditForm(int id, string type, string brand, string manufacturer, DateTime expiryDate, string supplier, decimal price)
        {
            InitializeComponent();
            Id = id;
            Type = type;
            Brand = brand;
            Manufacturer = manufacturer;
            ExpiryDate = expiryDate;
            Supplier = supplier;
            Price = price;

            // Заповнити поля текстовими значеннями
            typeTextBox.Text = type;
            brandTextBox.Text = brand;
            manufacturerTextBox.Text = manufacturer;
            expiryDatePicker.Value = expiryDate;
            supplierTextBox.Text = supplier;
            priceTextBox.Text = price.ToString();
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
        }
    }
}
