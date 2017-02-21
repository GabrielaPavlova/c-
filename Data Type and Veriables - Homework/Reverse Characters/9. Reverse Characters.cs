using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = Console.ReadLine();
            string secoundLetter = Console.ReadLine();
            string lastLetter = Console.ReadLine();

            Console.WriteLine($"{lastLetter}{secoundLetter}{firstLetter}");


        }
    }
}
