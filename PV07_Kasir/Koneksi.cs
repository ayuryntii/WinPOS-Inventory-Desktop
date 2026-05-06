using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PV07_Kasir
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            // Menggunakan (localdb)\MSSQLLocalDB karena Anda menggunakan SQL Server Express LocalDB
            Conn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Kasir;Integrated Security=True";
            return Conn;
        }
    }
}
