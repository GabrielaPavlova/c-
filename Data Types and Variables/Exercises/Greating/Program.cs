using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting

{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string ageStr = Console.ReadLine();

            int age = int.Parse(ageStr); // parse string to int

            Console.WriteLine($"Hello {firstName} {lastName}. \r\n You are  {age} years old."); // domashno



        }
    }
}
