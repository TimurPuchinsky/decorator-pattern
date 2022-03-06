using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programm
{
    public abstract class Beverage
    {
        protected string description = "";
        protected bool milk=false, soy=false, mocha=false, whip=false;
        protected double payment = 0;
        public double cost()
        {
            if (milk) payment = 5 + payment;
            if (soy) payment = 4 + payment;
            if (mocha) payment = 6 + payment;
            if (whip) payment = 8 + payment;
            return payment;
        }
        public string getDescription()
        {
            return description;
        }
        public void setMilk()
        {
            description = description + "Milk";
            milk = true;
        }
        public void setSoy()
        {
            description = description + "Soy";
            soy = true;
        }
        public void setMocha()
        {
            description = description + "Mocha";
            mocha = true;
        }
        public void setWhip()
        {
            description = description + "Whip";
            whip = true;
        }
    }
}
