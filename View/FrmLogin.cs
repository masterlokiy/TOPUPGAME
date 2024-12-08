using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TOPUPGAME.Model.Repository;
using TOPUPGAME.Model.Context;
using TOPUPGAME.Model.Entity;
using TOPUPGAME.All_Form.Form_Lupa_Password;
using TOPUPGAME.Controller;

namespace TOPUPGAME
{
    public partial class frmlogin : Form
    {
        private UserController _userController;

        public frmlogin(UserController userController)
        {
            InitializeComponent();

            this.MinimumSize = new Size(900, 600);

            _userController = userController;
        }


        //START LABEL LUPA PASSWORD
        private void lblLupaPassword_Click(object sender, EventArgs e)
        {
            FrmLupaPasswordPart1 frmLupaPassword = new FrmLupaPasswordPart1(_userController);
            frmLupaPassword.Show();
            this.Hide();

        }

        private void lblLupaPassword_MouseEnter(object sender, EventArgs e)
        {
            // Saat mouse masuk, ubah warna dan tambahkan garis bawah
            lblLupaPassword.ForeColor = Color.Blue;
            Font currentFont = lblLupaPassword.Font;
            Font newFont = new Font(currentFont, FontStyle.Underline);
            lblLupaPassword.Font = newFont;
        }

        private void lblLupaPassword_MouseLeave(object sender, EventArgs e)
        {
            // Saat mouse keluar, kembalikan warna dan hapus garis bawah
            lblLupaPassword.ForeColor = SystemColors.ControlText;  // Warna teks default
            Font currentFont = lblLupaPassword.Font;
            Font newFont = new Font(currentFont, FontStyle.Regular);
            lblLupaPassword.Font = newFont;
        }
        //END LABEL LUPA PASSWORD


        //START LABEL DAFTAR AKUN
        private void lblDaftarAkun_Click(object sender, EventArgs e)
        {
            FrmDaftarAkun formDaftarAkun = new FrmDaftarAkun();
            formDaftarAkun.Show();
            this.Hide();
        }

        private void lblDaftarAkun_MouseEnter(object sender, EventArgs e)
        {
            // Saat mouse masuk, ubah warna dan tambahkan garis bawah
            lblDaftarAkun.ForeColor = Color.Blue;
            Font currentFont = lblDaftarAkun.Font;
            Font newFont = new Font(currentFont, FontStyle.Underline);
            lblDaftarAkun.Font = newFont;
        }

        private void lblDaftarAkun_MouseLeave(object sender, EventArgs e)
        {
            // Saat mouse keluar, kembalikan warna dan hapus garis bawah
            lblDaftarAkun.ForeColor = SystemColors.ControlText;  // Warna teks default
            Font currentFont = lblDaftarAkun.Font;
            Font newFont = new Font(currentFont, FontStyle.Regular);
            lblDaftarAkun.Font = newFont;
        }
        //END LABEL DAFTAR AKUN



        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string emailOrUsername = txtUsernameEmail.Text;
            string password = txtPassword.Text;

            bool isAuthenticated = _userController.CekPengguna(emailOrUsername, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login berhasil.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login gagal. Periksa kembali email/username dan password.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah kamu yakin ingin keluar?", "Konfirmasi Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                this.Show();
            }
        }

        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
