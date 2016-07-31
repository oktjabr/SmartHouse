using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgect
{
    class Alarm
    {
        public void ShowAlarm()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" xx  x     xx   xxx   x       x   ");
            Console.WriteLine("x  x x    x  x  x  x  x x   x x   ");
            Console.WriteLine("x  x x    xxxx  xxx   x   x   x   ");
            Console.WriteLine("xxxx x    x  x  x  x  x       x   ");
            Console.WriteLine("x  x xxxx x  x  x   x x       x   ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("БЕГИТЕ ГЛУПЦЫ !!!!!!!");

        }
    }
}
