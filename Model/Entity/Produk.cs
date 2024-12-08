using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOPUPGAME.Model.Entity
{
    public class Produk
    {
        public int IDProduk { get; set; }
        public string NamaGame { get; set; }
        public string NamaProduk { get; set; }
        public int Harga {  get; set; }
        public string Image { get; set; }
    }
}
