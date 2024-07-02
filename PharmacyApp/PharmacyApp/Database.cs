using System;
using System.Data;
using System.Data.SqlClient;

namespace PharmacyApp
{
    public class Database
    {
        //private string connectionString = "Server=DESKTOP-AVC5O7R;Database=PharmacyDB;Integrated Security=true";
        private string connectionString = "Persist Security Info=False;Integrated Security = SSPI; database = PharmacyDB; server = (LocalDB)\\MSSQLLocalDB";
        public DataTable GetMedications()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Medications", connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void AddMedication(string type, string brand, string manufacturer, DateTime expiryDate, string supplier, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Medications (Type, Brand, Manufacturer, ExpiryDate, Supplier, Price) VALUES (@Type, @Brand, @Manufacturer, @ExpiryDate, @Supplier, @Price)", connection))
                {
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                    command.Parameters.AddWithValue("@Supplier", supplier);
                    command.Parameters.AddWithValue("@Price", price);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateMedication(int id, string type, string brand, string manufacturer, DateTime expiryDate, string supplier, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Medications SET Type=@Type, Brand=@Brand, Manufacturer=@Manufacturer, ExpiryDate=@ExpiryDate, Supplier=@Supplier, Price=@Price WHERE Id=@Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Brand", brand);
                    command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@ExpiryDate", expiryDate);
                    command.Parameters.AddWithValue("@Supplier", supplier);
                    command.Parameters.AddWithValue("@Price", price);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteMedication(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Medications WHERE Id=@Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
