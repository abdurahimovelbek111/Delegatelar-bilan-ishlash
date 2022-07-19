using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatelar_bilan_ishlash
{
    public class Pul
    {
        public int Miqdori { get; set; }
        public string Valyuta { get; set; }
        public Pul(int miqdori)
        {
            Miqdori = miqdori;
            Valyuta = "UZB";
        }
        public delegate void PulDelegate(Pul pul);
    }
}
