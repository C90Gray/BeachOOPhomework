using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachOOPHw
{
    class Program
    {
        static void Main(string[] args)
        {
            Beach loc1 = new Beach();
            Console.WriteLine("What is your eye color?");
            string color = Console.ReadLine().ToLower();
            loc1.GetBeachLocation(loc1.SetEyeValue(color));

        }
    }
}
