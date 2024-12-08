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
    public partial class HomeCustomer : Form
    {
        public HomeCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Profile profil = new Profile();
            this.Hide();
            profil.ShowDialog();
            this.Show();
        }

        private void lblFF_Click(object sender, EventArgs e)
        {
            string NamaGame = "Free Fire";
            FrmBuatPesanan frmBuatPesanan = new FrmBuatPesanan(NamaGame);
            this.Hide();
            frmBuatPesanan.ShowDialog();
            this.Show();

        }

        private void lblCOD_Click(object sender, EventArgs e)
        {
            this.Hide();
            string NamaGame = "Call Of Duty";
            FrmBuatPesanan frmBuatPesanan = new FrmBuatPesanan(NamaGame);
            frmBuatPesanan.Show();
            this.Show();
        }

        private void lblPUBG_Click(object sender, EventArgs e)
        {
            this.Hide();
            string NamaGame = "PUBG Mobile";
            FrmBuatPesanan frmBuatPesanan = new FrmBuatPesanan(NamaGame);
            frmBuatPesanan.Show();
            this.Show();
        }

        private void lblML_Click(object sender, EventArgs e)
        {
            this.Hide();
            string NamaGame = "Mobile Legend";
            FrmBuatPesanan frmBuatPesanan = new FrmBuatPesanan(NamaGame);
            frmBuatPesanan.Show();
            this.Show();
        }

        private void lblVALO_Click(object sender, EventArgs e)
        {
            this.Hide();
            string NamaGame = "Valorant";
            FrmBuatPesanan frmBuatPesanan = new FrmBuatPesanan(NamaGame);
            frmBuatPesanan.Show();
            this.Show();
        }
    }
}
