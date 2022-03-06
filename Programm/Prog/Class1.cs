using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programm;

namespace Prog
{
    class Class1
    {
        static void Main(string[] args)
        {
            DarkRoast dark = new DarkRoast();
            Decaf decaf = new Decaf();

            decaf.setMilk();
            decaf.setMocha();
            Console.WriteLine($"{decaf.cost()} - {decaf.getDescription()}");

            dark.setMilk();
            dark.setMocha();
            dark.setSoy();
            dark.setWhip();
            Console.WriteLine($"{dark.cost()} - {dark.getDescription()}");
            Console.ReadKey();
        }
    }
}
