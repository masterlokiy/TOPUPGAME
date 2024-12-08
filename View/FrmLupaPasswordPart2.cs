using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOPUPGAME.All_Form.Form_Lupa_Password;
using TOPUPGAME.Controller;
using TOPUPGAME.Model.Repository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TOPUPGAME
{
    public partial class FrmLupaPasswordPart2 : Form
    {
        private UserController _userController;

        public FrmLupaPasswordPart2(UserController userController)
        {
            InitializeComponent();
            _userController = userController;

        }

        private void FrmLupaPassword_FormClosing(object sender, FormClosingEventArgs e)
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
        private void btnGantiPassword_Click(object sender, EventArgs e)
        {
            try
            {
                string newPassword = txtPasswordBaru.Text;
                string verificationCode = txtKodeVerifikasi.Text;

                _userController.GantiPassword(newPassword, verificationCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKembalilupapasswordpart2_Click(object sender, EventArgs e)
        {
            FrmLupaPasswordPart1 frmLupaPasswordPart1 = new FrmLupaPasswordPart1(_userController);
            frmLupaPasswordPart1.Show();
            this.Hide();
        }
    }
}