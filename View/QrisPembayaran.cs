using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add the namespace where Pemesanan and PemesananController are defined
using TOPUPGAME.Model.Entity;
using TOPUPGAME.Controller;

namespace TOPUPGAME.View
{
    public partial class QrisPembayaran : Form
    {
        // Create an instance of PemesananController
        private PemesananController _pemesananController = new PemesananController();

        public QrisPembayaran()
        {
            InitializeComponent();
        }

        private void QrisPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSB_Click(object sender, EventArgs e)
        {

            int idpesan = 5;

            Pemesanan psn = new Pemesanan { IDPesan = idpesan };

            int result = _pemesananController.UpdateSBL(psn);

            if (result > 0)
            {
                // Update successful
                MessageBox.Show("Status bayar updated successfully.");
            }
            else
            {
                // Update failed
                MessageBox.Show("Failed to update status bayar.");
            }

        }

    }
}
