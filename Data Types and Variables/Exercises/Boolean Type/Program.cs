using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 1;

            bool greaterAB = (a > b); // true po - golqmo
            Console.WriteLine(greaterAB);
            bool equal = (a == b); // false -- ravno 
            Console.WriteLine(equal);
        }
    }
}
