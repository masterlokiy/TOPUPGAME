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
    public partial class RiwayatPembelian : Form
    {

        private List<Pemesanan> listofPemesanan = new List<Pemesanan>();
        private PemesananController psnController;

        public RiwayatPembelian()
        {
            InitializeComponent();
            psnController = new PemesananController();
            InisialisasiListView();
            LoadDataPemesanan();
        }

        private void InisialisasiListView()
        {
            lvwPemesanan.View = System.Windows.Forms.View.Details;
            lvwPemesanan.FullRowSelect = true;
            lvwPemesanan.GridLines = true;
            lvwPemesanan.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwPemesanan.Columns.Add("Nomor Pemesanan", 120, HorizontalAlignment.Center);
            lvwPemesanan.Columns.Add("Nama Produk", 80, HorizontalAlignment.Center);
            lvwPemesanan.Columns.Add("Harga Produk", 80, HorizontalAlignment.Center);
            lvwPemesanan.Columns.Add("ID Akun", 80, HorizontalAlignment.Center);
            lvwPemesanan.Columns.Add("Status Bayar", 80, HorizontalAlignment.Center);
            lvwPemesanan.Columns.Add("Kondisi", 80, HorizontalAlignment.Center);
            lvwPemesanan.Columns.Add("Tanggal", 80, HorizontalAlignment.Center);
        }


        private void LoadDataPemesanan()
        {
            //Id user sementara
            int Id = 3;

            // kosongkan listview
            lvwPemesanan.Items.Clear();

            // panggil method ReadByIDCustomer dan tampung datanya ke dalam collection
            listofPemesanan = psnController.ReadByIDCustomer(Id);

            // ekstrak objek pemesanan dari collection
            foreach (var psn in listofPemesanan)
            {
                var noUrut = lvwPemesanan.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(psn.IDPesan.ToString()); // Assuming IDPesan is not a string
                item.SubItems.Add(psn._Produk.NamaProduk);
                item.SubItems.Add(psn._Produk.Harga.ToString());
                item.SubItems.Add(psn._AkunUserGame.IDAkun.ToString()); // Assuming Id is not a string
                item.SubItems.Add(psn.StatusBayar);
                item.SubItems.Add(psn.StatusProses);
                item.SubItems.Add(psn.TanggalPesan.ToString());

                // tampilkan data pemesanan ke listview
                lvwPemesanan.Items.Add(item);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (lvwPemesanan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah Pembelian ingin dibatalkan ? ", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau diedit dari collection
                    Pemesanan psn = listofPemesanan[lvwPemesanan.SelectedIndices[0]];

                    psnController.Update(psn);

                    LoadDataPemesanan();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            }
           
        }
    }
}
