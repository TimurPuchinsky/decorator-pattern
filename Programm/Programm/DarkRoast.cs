using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark roast coffee";
            payment = 25;
        }
        public new double cost()
        {
            return base.cost();
        }
    }
}
