using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace teller_pause
{
    class Exe
    {
        static void Main()
        {
            Teller teller = new Teller();
            bool run = true;
            Boolean tel = true;
            long time = 0;
            int timer = 0;
            while (run == true)
            {
                ConsoleKeyInfo keypress = new ConsoleKeyInfo();
                if (tel == false)
                {
                    keypress = Console.ReadKey();
                    ConsoleKey key = keypress.Key;
                    switch (key)
                    {
                        case ConsoleKey.F:
                            Console.WriteLine();
                            tel = true;
                            break;
                    }
                }
                while (tel == true)
                {
                    if (Console.KeyAvailable)
                    {
                        keypress = Console.ReadKey();
                    }
                    ConsoleKey key = keypress.Key;
                    switch (key)
                    {
                        case ConsoleKey.D:
                            tel = false;
                            break;
                    }

                    long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

                    if (milliseconds - time >= 1000)
                    {
                        timer++;
                        Console.WriteLine(timer);
                        time = milliseconds;
                    }
                }
            }
        }
    }
}
