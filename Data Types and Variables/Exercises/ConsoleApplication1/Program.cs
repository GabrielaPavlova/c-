using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Centures =");
            int centures = int.Parse(Console.ReadLine());
            int years = centures * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            long minutes = 60 * hours;

            Console.WriteLine("{0} centures = {1} year = {2} days = {3} hours = {4} minutes", centures, years, days, hours, minutes);

        }
    }
}
