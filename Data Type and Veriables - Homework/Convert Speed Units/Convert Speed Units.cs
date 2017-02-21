using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int distanseInMetras = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int time = hours * 3600 + minutes * 60 + seconds;
            float metersPerSeconds = distanseInMetras /(float) time;
            float kilometersPerHour = (metersPerSeconds *18)/ 5.0f;
            float milesPerHour = kilometersPerHour/1.609f;


            Console.WriteLine(metersPerSeconds);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);




        }
    }
}
