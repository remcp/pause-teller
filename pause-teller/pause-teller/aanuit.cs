using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pause_teller
{
    internal class Aanuit
    {
        public bool Switch(Boolean tel)
        {
            ConsoleKeyInfo keypress = new ConsoleKeyInfo();
            if (Console.KeyAvailable)
            {
                keypress = Console.ReadKey();
            }
            ConsoleKey key = keypress.Key;
            if (tel == false)
            {
                switch (key)
                {
                    case ConsoleKey.F:
                        Console.WriteLine();
                        tel = true;
                        break;
                }
            }
            else
            {
                switch (key)
                {
                    case ConsoleKey.D:
                        tel = false;
                        break;
                }
            }
            return tel;
        }
    }
}
