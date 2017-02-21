using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "koledna elha";
            string two = "koledni igrachki";

            string all = one + two;
            Console.WriteLine(all);


            // tova e s operatora Plus !

            string oneC = "koledna elha";
            string twoC = "koledni igrachki";

            string allC = string.Concat(oneC, twoC);
            Console.WriteLine(allC);
             
            // Tova e s Concat ! 

        }
    }
}
