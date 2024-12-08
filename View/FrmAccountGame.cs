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
    public partial class FrmAccountGame : Form
    {
        private List<AkunUserGame> listofAkunUserGame = new List<AkunUserGame>();
        private AkunUserGameController augController;

        public FrmAccountGame()
        {
            InitializeComponent();
            augController = new AkunUserGameController();
            InisialisasiListView();
            LoadDataAUG();
        }
        private void InisialisasiListView()
        {
            lvwAkunUserGame.View = System.Windows.Forms.View.Details;
            lvwAkunUserGame.FullRowSelect = true;
            lvwAkunUserGame.GridLines = true;
            lvwAkunUserGame.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwAkunUserGame.Columns.Add("ID Akun", 200, HorizontalAlignment.Center);
            lvwAkunUserGame.Columns.Add("Game", 200, HorizontalAlignment.Center);
        }

        private void LoadDataAUG()
        {
            int TempID = 2;

            // kosongkan listview
            lvwAkunUserGame.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listofAkunUserGame = augController.ReadByIDCustomer(TempID);
            // ekstrak objek mhs dari collection
            foreach (var aug in listofAkunUserGame)
            {
                var noUrut = lvwAkunUserGame.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(aug.IDAkun.ToString());
                item.SubItems.Add(aug.NamaGame);
                // tampilkan data mhs ke listview
                lvwAkunUserGame.Items.Add(item);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            FrmEntryAccountGame entryAccountGame = new FrmEntryAccountGame();
            this.Hide();
            entryAccountGame.ShowDialog();
            this.Show();
            LoadDataAUG();
        }

       private void btnHapus_Click(object sender, EventArgs e)
        {

            if (lvwAkunUserGame.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah akun game ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (konfirmasi == DialogResult.Yes)
                {
                    AkunUserGame aug = listofAkunUserGame[lvwAkunUserGame.SelectedIndices[0]];
                    
                    augController.Delete(aug);

                    LoadDataAUG();
                }
            }
            else
            {
                MessageBox.Show("Tolong pilih terlebih dahulu akun game.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

    }
}