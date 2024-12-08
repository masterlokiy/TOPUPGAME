using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOPUPGAME.Controller;
using TOPUPGAME.Model.Entity;

namespace TOPUPGAME.View
{
    public partial class FrmBuatPesanan : Form
    {
        private List<AkunUserGame> listofAkunUserGame = new List<AkunUserGame>();
        private List<Produk> listofProduk = new List<Produk>();
        private AkunUserGameController augController;
        private ProdukController pdkController;
        private int index = 0;
        private string NameGame;

        public FrmBuatPesanan(string NameGame)
        {
            InitializeComponent();
            augController = new AkunUserGameController();
            pdkController = new ProdukController();
            PictureBoxBerubah(NameGame);
            LoadDataCmbAug();
            LoadDataProduk(NameGame);
        }
        private void PictureBoxBerubah(string NameGame)
        {
            switch (NameGame)
            {
                case "Free Fire":
                    picLogoGame.Image = Properties.Resources.OIP;
                    break;
                case "Call Of Duty":
                    picLogoGame.Image = Properties.Resources.OIP;
                    break;
                case "PUBG Mobile":
                    picLogoGame.Image = Properties.Resources.OIP;
                    break;
                case "Mobile Legend":
                    picLogoGame.Image = Properties.Resources.OIP;
                    break;
                case "Valorant":
                    picLogoGame.Image = Properties.Resources.OIP;
                    break;
            }
        }

        private void LoadDataCmbAug()
        {
            int TempID = 3;

            cmbaug.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listofAkunUserGame = augController.ReadByIDCustomer(TempID);
            // ekstrak objek aug dari collection
            foreach (var aug in listofAkunUserGame)
            {
                // tampilkan data mhs ke listview
                cmbaug.Items.Add(aug.IDAkun);
            }
        }

        private void LoadDataProduk(string NamaGame)
        {
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listofProduk = pdkController.ReadByNama(NamaGame);

            int JumlahItem = listofProduk.Count();
            if( JumlahItem == index)
            {
                index = 0;
            }

            Produk TampilProduk = listofProduk[index];

            lblNamaProduk.Text = TampilProduk.NamaProduk;
            lblHargaProduk.Text = TampilProduk.Harga.ToString();
        }

        private void lblKembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            LoadDataProduk(NameGame);
        }

        private void btnBuatPesanan_Click(object sender, EventArgs e)
        {
            QrisPembayaran qrisPembayaran = new QrisPembayaran();
            this.Hide();
            qrisPembayaran.ShowDialog();
            this.Show();
        }
    }
}
