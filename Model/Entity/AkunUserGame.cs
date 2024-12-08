using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOPUPGAME.Model.Entity
{
    public class AkunUserGame
    {
        public int IDAkun { get; set; }
        public User _User { get; set; } = new User();        // Initialize the object
        public string NamaGame { get; set; }
    }
}
