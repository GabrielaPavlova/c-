using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {


            double lenght, widht, height, volume = 0;
            
            Console.Write("Length: ");
            lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            widht = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            volume = (lenght * widht * height) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2} ", volume); // ako iskame da e s int smenqma vsichki s INT samo voluma go pravim double
                                                                    // i sled tova delim na 3.0 

        }

    }
}
