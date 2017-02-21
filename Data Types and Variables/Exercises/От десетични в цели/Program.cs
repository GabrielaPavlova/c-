using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace От_десетични_в_цели
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.6785;
            Console.WriteLine(Math.Round(a)); // закръгля до най - близкото цяло число 
            Console.WriteLine(Math.Round(a,4)); // закръгля толкова знака колкото са оказани след запетайката
            Console.WriteLine(Math.Ceiling(a)); // Дига с 1 до следващото цяло число
            Console.WriteLine(Math.Floor(a)); // Маха всичко след десетичната запетайка

        }
    }
}
