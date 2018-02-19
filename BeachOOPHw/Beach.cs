using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachOOPHw
{
    public class Beach : Travel
    {

        public Beach()
        {
            IsABeach = true;
        }

        public override int SetEyeValue(string color)
        {
            if (color == "blue")
            {
                return 1;
            }
            else if (color == "brown")
            {
                return 2;
            }
            else if (color == "green")
            {
                return 3;
            }
            else
            {
                return 4;
            }
            
        }

        public void GetBeachLocation(int eyeNumb)
        {
            if (eyeNumb ==1)
            {
                Console.WriteLine("You'll be vacationing in Honolulu");
            }
            else if (eyeNumb == 2)
            {
                Console.WriteLine("You'll be vacationing in Miami Beach");
            }
            else if (eyeNumb == 3)
            {
                Console.WriteLine("You'll be vacationing in Rio");
            }
            else 
            {
                Console.WriteLine("You'll be vacationing in Lake Erie Beach");
            }
        }
    }
}
