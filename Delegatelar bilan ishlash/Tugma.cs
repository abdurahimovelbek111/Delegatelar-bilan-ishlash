using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatelar_bilan_ishlash
{
    public delegate void ClicEventHandler();
    public class Tugma
    {
        public event ClicEventHandler Click;
        public void Simulation()
        {
            if (Click!=null)
            {
                Click();
            }
            else
            {
                Console.WriteLine("Hodisa ro'y bermadi!!!");
            }
        }
    }
}
