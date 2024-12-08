using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOPUPGAME.Model.Entity
{
    public class Pemesanan
    {
        public int IDPesan { get; set; }
        public Produk _Produk { get; set; } = new Produk();  // Initialize the object
        public User _User { get; set; } = new User();        // Initialize the object
        public AkunUserGame _AkunUserGame { get; set; } = new AkunUserGame();  // Initialize the object
        public string StatusBayar { get; set; }
        public string StatusProses { get; set; }
        public DateTime TanggalPesan { get; set; }
    }
}
