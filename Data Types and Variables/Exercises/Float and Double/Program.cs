using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_and_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatPI = 3.141592653589793238f; // винаги накрая f .... зактъгля до 7 мо число
            double doublePI = 3.141592653589793238; // без d то само го разпознава до 15 знак
            Console.WriteLine("Float Pi is {0}", floatPI);
            Console.WriteLine("Double Pi is {0}",doublePI);
        }
    }
}
