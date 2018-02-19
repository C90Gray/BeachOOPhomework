using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeachOOPHw
{
     public abstract class Travel
    {
        protected bool IsABeach { get; set; }


        public abstract int SetEyeValue(string color);
    }
}
