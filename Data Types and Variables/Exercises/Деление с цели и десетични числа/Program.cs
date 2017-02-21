using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Деление_с_цели_и_десетични_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(10 / 4); // дава сами 2
            Console.WriteLine(10 / 4.00); // дава 2.5 което е верния отговор. Трябва поне едно от числата да е десетично
            Console.WriteLine(10 / 0.00); // Безкрайност
            Console.WriteLine(0 / 0.0); // Nan
            Console.WriteLine(8 % 2.5); // 0.5
        }
    }
}
