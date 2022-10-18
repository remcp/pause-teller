using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using pause_teller;

namespace Pause_teller
{
    unsafe class Exe
    {
        public static void Main()
        {
            Teller teller = new Teller();
            Aanuit aanuit = new Aanuit();
            bool run = true;
            Boolean tel = true;
            long time = 0;
            long* ptrtime = &time;
            int timer = 0;
            while (run == true)
            {
                tel = aanuit.Switch(tel);
                if (tel == true)
                {
                    long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                    timer = teller.Tel(timer, ptrtime, milliseconds);
                }
            }
        }
    }
}