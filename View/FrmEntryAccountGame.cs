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
    public partial class FrmEntryAccountGame : Form
    {
        private AkunUserGameController augController;
        private AkunUserGame aug;

        public FrmEntryAccountGame()
        {
            augController = new AkunUserGameController();
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            int TempID = 2;

            aug = new AkunUserGame();
            // set nilai property objek mahasiswa yg diambil dari TextBox
            aug.IDAkun = Convert.ToInt32(txtIDAkun.Text);
            aug._User.Id = TempID;
            aug.NamaGame = cmbNamaGame.Text;

            int result = 0;

            // panggil operasi CRUD
            result = augController.Create(aug);
            if (result > 0) // tambah data berhasil
            {
                txtIDAkun.Clear();
            }

            this.Close();
        }
    }
}
