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
    public class PemesananController
    {
        private PemesananRepository _PemesananRepository;

        public PemesananController()
        {
            _PemesananRepository = new PemesananRepository(new DbContext());
        }

        public List<Pemesanan> ReadByIDCustomer(int IDCustomer)
        {
            // membuat objek collection
            List<Pemesanan> list = new List<Pemesanan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _PemesananRepository = new PemesananRepository(context);

                // panggil method ReadByNama yang ada di dalam class repository
                list = _PemesananRepository.ReadByIDCustomer(IDCustomer);
            }

            return list;
        }

        public int Create(Pemesanan psn)
        {
            int result = 0;

            // cek IDAkun yang diinputkan tidak boleh kosong
            if (psn._User.Id == 0)
            {
                MessageBox.Show("ID Akun harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _PemesananRepository = new PemesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _PemesananRepository.Create(psn);
            }

            return result;
        }
        

        public int Update(Pemesanan psn)
        {
            int result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _PemesananRepository = new PemesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _PemesananRepository.Update(psn);
            }

            return result;
        }

        public int UpdateSB(Pemesanan psn)
        {
            int result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _PemesananRepository = new PemesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _PemesananRepository.UpdateSB(psn);
            }

            return result;
        }

                
        public int UpdateSBL(Pemesanan psn)
        {
            int result = 0;

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _PemesananRepository = new PemesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _PemesananRepository.UpdateSBL(psn);
            }
            return result;
        }

        public int Delete(int Id)
        {
            int result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _PemesananRepository = new PemesananRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _PemesananRepository.Delete(Id);
            }

            return result;
        }

    }
}
