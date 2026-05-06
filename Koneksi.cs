using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PV_7_KasirInsert
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            // Catatan: Ganti Data Source sesuai dengan nama Server SQL Anda (contoh: localhost atau .\SQLEXPRESS)
            Conn.ConnectionString = "Data Source = ANDREW-BENEDICT; initial catalog = Kasir; integrated security = true";
            return Conn;
        }
    }
}
