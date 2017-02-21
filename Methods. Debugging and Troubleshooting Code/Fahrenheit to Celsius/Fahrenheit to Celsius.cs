using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_to_Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature in Farenheit: ");
            double t = double.Parse(Console.ReadLine());
            t = FarenheitToCelsius(t);
            Console.WriteLine("Temprature in Celsius: {0}", t); // ot celzi vyv farenhait 

        }
        static double FarenheitToCelsius  (double degrees)
        {
            double celsius = (degrees - 32) * 5 / 9;
            return celsius;

        }


    }

}
