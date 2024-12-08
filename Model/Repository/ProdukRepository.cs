using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TOPUPGAME.Model.Entity;
using TOPUPGAME.Model.Context;
using System.Drawing;

namespace TOPUPGAME.Model.Repository
{
    public class ProdukRepository
    {
        private SqlConnection _conn;

        public ProdukRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        
        public List<Produk> ReadByNama(string NamaGame)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Produk> list = new List<Produk>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select IDProduk, NamaProduk, Harga , Image 
                               from Produk 
                               where NamaGame like @NamaGame
                               order by NamaGame";

                // membuat objek command menggunakan blok using
                using (SqlCommand cmd = new SqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@NamaGame", string.Format("%{0}%", NamaGame));

                    // membuat objek reader (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (reader.Read())
                        {
                            // proses konversi dari row result set ke object
                            Produk pdk = new Produk();
                            pdk.IDProduk = Convert.ToInt32(reader["IDProduk"]);
                            pdk.NamaProduk = reader["NamaProduk"].ToString();
                            pdk.Harga = Convert.ToInt32(reader["Harga"]);
                            pdk.Image = reader["Image"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(pdk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
        
    }
}
