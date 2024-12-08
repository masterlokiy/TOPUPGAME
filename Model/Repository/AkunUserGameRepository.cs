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
    public class AkunUserGameRepository
    {
        private SqlConnection _conn;

        public AkunUserGameRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        //customer nambah akun game
        public int Create(AkunUserGame aug)
        {
            int result = 0;

            // deklarasi perintah SQL
            string query = @"insert into AkunUserGame (IDAkun, Id ,NamaGame)
                           values (@IDAkun, @Id ,@NamaGame)";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@IDAkun", aug.IDAkun);
                cmd.Parameters.AddWithValue("@Id", aug._User.Id);
                cmd.Parameters.AddWithValue("@NamaGame", aug.NamaGame);

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

        public int DeleteByUserId(int Id)
        {
            int result = 0;

            //deklarasi perintah SQL
            string query = @"delete from AkunUserGame where Id = @Id";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {

                // mendaftarkan parameter dan mengeset nilainnya
                cmd.Parameters.AddWithValue("@Id", Id);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        //customer hapus akun game berdasar akun
        public int Delete(AkunUserGame aug)
        {

            int result = 0;

            // deklarasi perintah SQL
            string query = @"delete from AkunUserGame
                           where IDAkun = @IDAkun";

            // membuat objek command menggunakan blok using
            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@IDAkun", aug.IDAkun);

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
        
        // Method untuk menampilkan data akun user berdasarkan id customer
        public List<AkunUserGame> ReadByIDCustomer(int Id)
        {
            // membuat objek collection untuk menampung objek AkunUserGame
            List<AkunUserGame> list = new List<AkunUserGame>();

            try
            {
                // deklarasi perintah SQL
                string query = @"select IDAkun, NamaGame 
                               from AkunUserGame 
                               where Id Like @Id
                               order by NamaGame";

                // membuat objek command menggunakan blok using
                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@Id", Id);

                    // membuat objek reader (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (reader.Read())
                        {
                            // proses konversi dari row result set ke object
                            AkunUserGame aug = new AkunUserGame();
                            aug.IDAkun = Convert.ToInt32(reader["IDAkun"]);  // Use Convert.ToInt32 for NUMERIC
                            aug.NamaGame = reader["NamaGame"].ToString();

                            // tambahkan objek AkunUserGame ke dalam collection
                            list.Add(aug);
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
