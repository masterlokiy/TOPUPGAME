using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TOPUPGAME.Model.Entity;
using TOPUPGAME.Model.Context;

namespace TOPUPGAME.Model.Repository
{
    public class UserRepository
    {
        private SqlConnection _conn;

        public UserRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public void TambahUser(User user)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO User (Username, Email, Password, PhoneNumber) VALUES (@Username, @Email, @Password, @PhoneNumber)", _conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error membuat akun: {ex.Message}");

            }
        }

        public bool CekUser(string emailOrUsername, string password)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM User WHERE (Email = @EmailOrUsername OR Username = @EmailOrUsername) AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@EmailOrUsername", emailOrUsername);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)cmd.ExecuteScalar();

                    return userCount > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error authenticating user: {ex.Message}");
                return false;
            }
        }

        public string CariEmaildanUsername(string emailOrUsername)
        {
            string query = "SELECT Email FROM User WHERE Username = @Username OR Email = @Email";

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", emailOrUsername);
                cmd.Parameters.AddWithValue("@Email", emailOrUsername);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        return reader["Email"].ToString();
                    }
                }
            }

            return string.Empty;
        }


        public void UpdateKodeVerif(string userEmail, string verificationCode)
        {
            try
            {
                string query = "UPDATE User SET VerificationCode = @VerificationCode WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@VerificationCode", verificationCode);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error storing verification code: {ex.Message}");
            }
        }

        public bool CekKodeVerif(string userEmail, string verificationCode)
        {
            
            string query = "SELECT COUNT(*) FROM User WHERE Email = @Email AND VerificationCode = @VerificationCode";

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@Email", userEmail);
                cmd.Parameters.AddWithValue("@VerificationCode", verificationCode);

                int codeCount = (int)cmd.ExecuteScalar();

                return codeCount > 0;
            }
        }

        public void UpdatePassword(string userEmail, string newPassword)
        {
            try
            {
                
                string query = "UPDATE User SET Password = @Password, VerificationCode = NULL WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, _conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPassword);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating password: {ex.Message}");
            }
        }

        public string CariEmaildanUsernameDariVerifyKode(string verificationCode)
        {
            string query = "SELECT Email FROM User WHERE VerificationCode = @VerificationCode";

            using (SqlCommand cmd = new SqlCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@VerificationCode", verificationCode);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["Email"].ToString();
                    }
                }
            }

            return string.Empty;
        }

         public int DeleteByUserId(int Id)
        {
            int result = 0;

            //deklarasi perintah SQL
            string query = @"delete from [User] where Id = @Id";

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
         
    }
}
