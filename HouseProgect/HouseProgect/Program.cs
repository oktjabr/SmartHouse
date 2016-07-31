using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseProgect
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            house.InspectUser();
           
            Console.ReadKey();
        }
    }
}
