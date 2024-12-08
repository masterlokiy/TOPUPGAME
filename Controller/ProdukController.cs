using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOPUPGAME.Model.Repository;
using TOPUPGAME.Model.Context;
using TOPUPGAME.Model.Entity;

namespace TOPUPGAME.Controller
{
    public class ProdukController
    {
        private ProdukRepository _ProdukRepository;

        public ProdukController()
        {
            _ProdukRepository = new ProdukRepository(new DbContext());
        }

        public List<Produk> ReadByNama(string NamaGame)
        {
            // membuat objek collection
            List<Produk> list = new List<Produk>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _ProdukRepository = new ProdukRepository(context);

                // panggil method ReadByNama yang ada di dalam class repository
                list = _ProdukRepository.ReadByNama(NamaGame);
            }

            return list;
        }
    }
}
