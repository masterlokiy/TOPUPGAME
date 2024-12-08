using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TOPUPGAME.Model.Context
{
    public class DbContext : IDisposable
    {
        // Deklarasi private variabel / field
        private SqlConnection _conn;

        // Deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public SqlConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        // Method untuk melakukan koneksi ke database
        private SqlConnection GetOpenConnection()
        {
            SqlConnection conn = null; // Deklarasi objek connection

            try
            {
                // Atur ulang informasi koneksi sesuai dengan server SQL Server Anda
                string serverName = "ILHAMPC\\SQLEXPRESS";
                string dbName = "TOPUPGAME";

                // For Windows Authentication, you don't need a specific username and password
                string connectionString = $"Data Source={serverName};Initial Catalog={dbName};Integrated Security=True;";

                conn = new SqlConnection(connectionString); // Buat objek connection
                conn.Open(); // Buka koneksi ke database
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print($"Open Connection Error: {ex.Message}");
            }

            return conn;
        }

        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
