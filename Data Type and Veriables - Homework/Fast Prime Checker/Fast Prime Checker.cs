using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberDo = int.Parse(Console.ReadLine());
            for (int chekIt = 2; chekIt <= numberDo; chekIt++)
            {
                bool isNumber = true;
                for (int anotherNum = 2; anotherNum <= Math.Sqrt(chekIt); anotherNum++)
                {
                    if (chekIt % anotherNum == 0)
                    {
                        isNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{chekIt} -> {isNumber}");
            }
        }
    }
}
