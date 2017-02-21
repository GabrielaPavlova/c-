using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Debugging_and_Troubleshooting
{
    class demo
    {

  


        static void Main(string[] args)
        {
            PrintReceipt();
        }

        // tuk trqbva da sysdadem Metoda 
        private static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();


        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("-------------------------");

        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to ______________");
            Console.WriteLine("Received by ______________");
        }

        private static void PrintFooter()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("\u00A9 SoftUni");

        }
    }
}
