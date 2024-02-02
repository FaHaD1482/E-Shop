using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Shop.Database
{
    public abstract class DatabaseConnection
    {
        const string connectionString = @"Data Source=Fahad\SQLEXPRESS;Initial Catalog=E-Shop;Integrated Security=True";
        public static SqlConnection databaseConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
