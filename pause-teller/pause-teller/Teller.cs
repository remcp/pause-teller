using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pause_teller
{
    unsafe class Teller
    {
        public int Tel(int timer, long* ptrtime, long milliseconds)
        {

            if (milliseconds - *ptrtime >= 1000)
            {
                timer++;
                Console.WriteLine(timer);
                *ptrtime = milliseconds;
            }

            return timer;
        }
    }
}