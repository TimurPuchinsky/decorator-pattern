using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
            payment = 20;
        }
        public new double cost()
        {
            return base.cost();
        }
    }
}
