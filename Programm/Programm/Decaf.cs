using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf coffee";
            payment = 15;
        }
        public new double cost()
        {
            return base.cost();
        }
    }
}
