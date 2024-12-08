using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TOPUPGAME.Model.Repository;
using TOPUPGAME.Model.Context;
using TOPUPGAME.Model.Entity;

namespace TOPUPGAME.Controller
{
    public class AkunUserGameController
    {
        private AkunUserGameRepository _AkunUserGameRepository;

        public AkunUserGameController()
        {
            _AkunUserGameRepository = new AkunUserGameRepository(new DbContext());
        }

        public List<AkunUserGame> ReadByIDCustomer(int IDCustomer)
        {
            // membuat objek collection
            List<AkunUserGame> list = new List<AkunUserGame>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _AkunUserGameRepository = new AkunUserGameRepository(context);

                // panggil method ReadByNama yang ada di dalam class repository
                list = _AkunUserGameRepository.ReadByIDCustomer(IDCustomer);
            }

            return list;
        }

        public int Create(AkunUserGame aug)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (aug.IDAkun == 0)
            {
                MessageBox.Show("ID Akun harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(aug.NamaGame))
            {
                MessageBox.Show("Game harus dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _AkunUserGameRepository = new AkunUserGameRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _AkunUserGameRepository.Create(aug);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Akun Game berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Akun Game gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(AkunUserGame aug)
        {
            int result = 0;

            if (aug.IDAkun==0)
            {
                MessageBox.Show("Data Akun Harus Dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _AkunUserGameRepository = new AkunUserGameRepository(context);

                result = _AkunUserGameRepository.Delete(aug);
            }
             
            if (result > 0)
            {
                MessageBox.Show("Data Akun Game berhasil dihapus!", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Akun Game gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

         public int DeleteById(int Id)
        {
            int result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _AkunUserGameRepository = new AkunUserGameRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _AkunUserGameRepository.DeleteByUserId(Id);
            }

            return result;
        }


    }
}

