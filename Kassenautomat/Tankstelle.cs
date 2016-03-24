using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat
{
    public class Tankstelle
    {
        public int Lieferabstand { get; set; }

        public Tankstelle()
        {
            Lieferabstand = 5;
        }

        public Tankstelle(int pLieferabstand){
            Lieferabstand = pLieferabstand;
        }
    }
}
