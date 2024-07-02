using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class MainForm : Form
    {
        private Database db = new Database();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = db.GetMedications();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                db.AddMedication(addForm.Type, addForm.Brand, addForm.Manufacturer, addForm.ExpiryDate, addForm.Supplier, addForm.Price);
                LoadData();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedRow = dataGridView1.CurrentRow;
                EditForm editForm = new EditForm(
                    (int)selectedRow.Cells["Id"].Value,
                    selectedRow.Cells["Type"].Value.ToString(),
                    selectedRow.Cells["Brand"].Value.ToString(),
                    selectedRow.Cells["Manufacturer"].Value.ToString(),
                    (DateTime)selectedRow.Cells["ExpiryDate"].Value,
                    selectedRow.Cells["Supplier"].Value.ToString(),
                    (decimal)selectedRow.Cells["Price"].Value
                );

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    db.UpdateMedication(editForm.Id, editForm.Type, editForm.Brand, editForm.Manufacturer, editForm.ExpiryDate, editForm.Supplier, editForm.Price);
                    LoadData();
                }
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Contains("Price"))
                dataGridView1.Sort(dataGridView1.Columns["Price"], System.ComponentModel.ListSortDirection.Ascending);

            else
                MessageBox.Show("Колонка 'Price' відсутня у таблиці.");

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idToDelete = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                db.DeleteMedication(idToDelete);

                LoadData();
            }
        }
    }
}
