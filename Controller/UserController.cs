using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOPUPGAME.Model.Repository;
using TOPUPGAME.Model.Context;
using TOPUPGAME.Model.Entity;
using System.Net;
using System.Net.Mail;
using TOPUPGAME.All_Form.Form_Lupa_Password;

namespace TOPUPGAME.Controller
{
    public class UserController
    {
        private UserRepository _userRepository;
        private AkunUserGameController _akunUserGameController;
        private PemesananController _pemesananController;

        public UserController()
        {
            _userRepository = new UserRepository(new DbContext());
            _akunUserGameController = new AkunUserGameController();
            _pemesananController = new PemesananController();
        }

        public bool DaftarPengguna(User newUser)
        {
            try
            {
                
                _userRepository.TambahUser(newUser);
                return true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Gagal mendaftarkan pengguna: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        public bool CekPengguna(string emailOrUsername, string password)
        {
            return _userRepository.CekUser(emailOrUsername, password);
        }

        public void CariEmaildanUsername(string usernameOrEmail, FrmLupaPasswordPart1 view)
        {
            string userEmail = _userRepository.CariEmaildanUsername(usernameOrEmail);

            if (!string.IsNullOrEmpty(userEmail))
            {

                string code = GenerateRandomCode();

                _userRepository.UpdateKodeVerif(userEmail, code);

                SendMessage(userEmail, code);

                FrmLupaPasswordPart2 frmLupaPasswordPart2 = new FrmLupaPasswordPart2(this);
                frmLupaPasswordPart2.Show();

                view.Hide();
            }
            else
            {
                MessageBox.Show("Username dan Email tidak ada. Coba lagi.");
            }
        }


        private string GenerateRandomCode()
        {
            Random random = new Random();
            int code = random.Next(100000, 999999);
            return code.ToString();
        }

        private void SendMessage(string emailAddress, string code)
        {
            try
            {
                if (!string.IsNullOrEmpty(emailAddress))
                {
                    string fromMail = "topupamikom7@gmail.com";
                    string fromPassword = "sifv mfrp dzfx ptxt";
                    string toMail = emailAddress;

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromMail);
                    message.Subject = "Verification Code";
                    message.To.Add(new MailAddress(toMail));
                    message.Body = $"<html><body>Your verification code is: {code}</body></html>";
                    message.IsBodyHtml = true;

                    var smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(message);
                }
                else
                {
                    MessageBox.Show("Email kosong. tidak bisa mengirim kode.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

         private void SendMessageBerhasilDaftar(string emailAddress, string code)
        {
            try
            {
                if (!string.IsNullOrEmpty(emailAddress))
                {
                    string fromMail = "topupamikom7@gmail.com";
                    string fromPassword = "sifv mfrp dzfx ptxt";
                    string toMail = emailAddress;

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(fromMail);
                    message.Subject = "Verification Code";
                    message.To.Add(new MailAddress(toMail));
                    message.Body = $"<html><body>Your verification code is: {code}</body></html>";
                    message.IsBodyHtml = true;

                    var smtpClient = new SmtpClient("smtp.gmail.com");
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
                    smtpClient.EnableSsl = true;

                    smtpClient.Send(message);
                }
                else
                {
                    MessageBox.Show("Email kosong. tidak bisa mengirim kode.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void GantiPassword(string newPassword, string verificationCode)
        {
            try
            {
             
                string userEmail = _userRepository.CariEmaildanUsernameDariVerifyKode(verificationCode);

                if (!string.IsNullOrEmpty(userEmail))
                {
                    
                    if (_userRepository.CekKodeVerif(userEmail, verificationCode))
                    {
                        
                        _userRepository.UpdatePassword(userEmail, newPassword);

                        MessageBox.Show("Password sudah diubah.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                    }
                    else
                    {
                        MessageBox.Show("Kode verifikasi error. Coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User tidak ditemukan. coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


         public int DeleteByID(int Id)
        {
            int result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _userRepository= new UserRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _userRepository.DeleteByUserId(Id);
            }

            return result;
        }

    }
}
