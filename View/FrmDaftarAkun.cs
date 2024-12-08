using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOPUPGAME.Model.Repository;
using TOPUPGAME.Model.Context;
using TOPUPGAME.Model.Entity;
using TOPUPGAME.Controller;


namespace TOPUPGAME
{
    public partial class FrmDaftarAkun : Form
    {
        private UserController _userController;

        public FrmDaftarAkun()
        {
            InitializeComponent();
            this.MinimumSize = new Size(900, 600);
            _userController = new UserController();
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {

            FrmVerifikasiDaftar frmVerifikasiDaftar = new FrmVerifikasiDaftar();
            frmVerifikasiDaftar.Show();
            this.Hide();
        }

        private void ClearTextBoxes()
        {
            // Fungsi untuk membersihkan nilai di TextBox
            txtDaftarUsername.Clear();
            txtDaftarEmail.Clear();
            txtDaftarPassword.Clear();
            txtDaftarNomor.Clear();
        }

        private void lblDaftarkeLogin_Click(object sender, EventArgs e)
        {
            frmlogin frmLogin = new frmlogin(_userController);
            frmLogin.Show();
            this.Hide();
        }

        private void FrmDaftarAkun_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah kamu yakin ingin keluar?", "Konfirmasi Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmlogin frmLogin = new frmlogin(_userController);
                frmLogin.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}