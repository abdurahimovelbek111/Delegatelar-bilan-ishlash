using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatelar_bilan_ishlash
{
    public class PulBoshqaruvchisi
    {
        public void Uzb2usd(Pul pul)
        {
            pul.Miqdori /= 10900;
            pul.Valyuta = "USD";
        }
        public void Usd2Uzb(Pul pul)
        {
            pul.Miqdori *= 10900;
            pul.Valyuta = "UZB";
        }
        public void Pul_Yuborish(Pul pul, string bank, Pul.PulDelegate @delegate)
        {
            if (@delegate.Target != null)
                @delegate(pul);
            
            Console.WriteLine(pul.Miqdori.ToString("0.00")+" "+pul.Valyuta+" Miqdoridagi pul "+bank+" Bankga muffaqatli pul o'tkazildi .\n" +
                "Etiboriz uchun Raxmat!!!!");
        }
        public void Pul_Olish(Pul pul, string bank, Pul.PulDelegate @delegate)
        {
            if (@delegate.Target != null)
                @delegate(pul);

            Console.WriteLine(pul.Miqdori.ToString("0.00") + " " + pul.Valyuta + " Miqdoridagi pul " + bank + " Bankdan muffaqatli pul olindi .\n" +
                "Etiboriz uchun Raxmat!!!!");

        }
    }
}
