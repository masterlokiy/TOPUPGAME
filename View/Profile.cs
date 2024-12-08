using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOPUPGAME.Model.Entity;
using TOPUPGAME.Controller;

namespace TOPUPGAME.View
{
    public partial class Profile : Form
    {
        private UserController _userController;
        private AkunUserGameController _akunusergamecontroller;
        private PemesananController _pemesananController;

        public Profile()
        {
            InitializeComponent();
             _pemesananController = new PemesananController();
            _akunusergamecontroller = new AkunUserGameController();
            _userController = new UserController();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RiwayatPembelian frmRiwayatPembelian = new RiwayatPembelian();
            this.Hide();
            frmRiwayatPembelian.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
             Application.Restart();
             Environment.Exit(0);
        }

        private void btnLogDel_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show("Apa kamu yakin ingin menghapus akun?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = 4;
                int pemesananDelete = _pemesananController.Delete(id);
                int akunDelete = _akunusergamecontroller.DeleteById(id);
                int userDelete = _userController.DeleteByID(id);

                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void btnUserID_Click(object sender, EventArgs e)
        {
            FrmAccountGame AccountGame = new FrmAccountGame();
            this.Hide();
            AccountGame.ShowDialog();
            this.Show();
        }
    }
}
