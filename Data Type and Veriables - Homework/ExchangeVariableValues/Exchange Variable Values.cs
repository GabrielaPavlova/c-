using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); // vyvejdame chislo
            int b = int.Parse(Console.ReadLine()); // vyvejdame chislo
            Console.WriteLine("Before:");         // predi 
            Console.WriteLine("a = {0}", a);      // samo razmenqme stojnostite na dvete promenlivi
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", b);
            Console.WriteLine("b = {0}", a);



        }
    }
}
