using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat
{
    public class Muenze
    {
        private int value;
        public int Value { get; set; }

        private int anzahl;
        public int Anzahl { get; set; }

        private int maximalWert = 100;
        public int MaximalWert
        {
            get
            {
                return maximalWert;
            }
        }

        public Muenze(int pValue)
        {
            value = pValue;
        }
    }
}
