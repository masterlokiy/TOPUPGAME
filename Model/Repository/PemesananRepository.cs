using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TOPUPGAME.Model.Entity;
using TOPUPGAME.Model.Context;

namespace TOPUPGAME.Model.Repository
{
    public class PemesananRepository
    {
        private SqlConnection _conn;

        public PemesananRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        //customer nambah pemesanan
        public int Create(Pemesanan psn)
        {
            int result = 0;

            // deklarasi perintah SQL
            string query = @"insert into UserAccount (IDPesan, IDProduk ,Id , IDAkun , StatusBayar , StatusProses , TanggalPesan)
                           values (@IDPesan, @IDProduk ,@Id , @IDAkun , @StatusBayar , @StatusProses , @TanggalPesan)";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@IDPesan", psn.IDPesan);
                cmd.Parameters.AddWithValue("@IDProduk", psn._Produk.IDProduk);
                cmd.Parameters.AddWithValue("@Id", psn._User.Id);
                cmd.Parameters.AddWithValue("@IDAkun", psn._AkunUserGame.IDAkun);
                cmd.Parameters.AddWithValue("@StatusBayar", psn.StatusBayar);
                cmd.Parameters.AddWithValue("@StatusCancel", psn.StatusProses);
                cmd.Parameters.AddWithValue("@TanggalPesan", psn.TanggalPesan);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Pemesanan psn)
        {
            int result = 0;

            psn.StatusProses = "Batal";

            // deklarasi perintah SQL
            string query = @"update Pemesanan set StatusProses = @StatusProses
                           where IDPesan = @IDPesan";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@IDPesan", psn.IDPesan);
                cmd.Parameters.AddWithValue("@StatusProses", psn.StatusProses);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int UpdateSB(Pemesanan psn)
        {
            int result = 0;

            // deklarasi perintah SQL
            string query = @"update Pemesanan set StatusBayar = @StatusBayar
                           where IDPesan = @IDPesan";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@IDPesan", psn.IDPesan);
                cmd.Parameters.AddWithValue("@StatusBayar", psn.StatusBayar);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int UpdateSBL(Pemesanan psn)
        {
            int result = 0;

            // deklarasi perintah SQL
            string query = @"update Pemesanan set StatusBayar = 'Lunas'
                        where IDPesan = @IDPesan";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@IDPesan", psn.IDPesan);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        
        public int Delete(int Id)
        {

            int result = 0;

            // deklarasi perintah SQL
            string query = @"delete from Pemesanan
                           where Id = @Id";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Id", Id);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Pemesanan> ReadByIDCustomer(int Id)
        {
            List<Pemesanan> list = new List<Pemesanan>();

            try
            {
                string query = @"SELECT
                            Pemesanan.IDPesan,
                            Produk.NamaProduk,
                            Produk.Harga,
                            Pemesanan.IDAkun,
                            Pemesanan.StatusBayar,
                            Pemesanan.StatusProses,
                            Pemesanan.TanggalPesan
                        FROM
                            Pemesanan
                        JOIN
                            Produk ON Pemesanan.IDProduk = Produk.IDProduk
                        WHERE
                            Pemesanan.Id = @Id;";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@Id", Id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pemesanan psn = new Pemesanan();
                            psn.IDPesan = Convert.ToInt32(reader["IDPesan"]);
                            psn._Produk.NamaProduk = reader["NamaProduk"].ToString();
                            psn._Produk.Harga = Convert.ToInt32(reader["Harga"]);
                            psn._AkunUserGame.IDAkun = Convert.ToInt32(reader["IDAkun"]);
                            psn.StatusBayar = reader["StatusBayar"].ToString();
                            psn.StatusProses = reader["StatusProses"].ToString();
                            psn.TanggalPesan = Convert.ToDateTime(reader["TanggalPesan"]);

                            list.Add(psn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByIDCustomer error: {0}", ex.Message);
            }

            return list;
        }

    }
}
