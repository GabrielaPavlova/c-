using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int person = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)person / capacity); // първо е дабле но после пак си го правим цяло число , а първо е дабле защото искаме да видим какъв ще бъде остатъка !

            Console.WriteLine(courses); // смята ни колко човека побира на един курс асансьора ! 
        }
    }
}
