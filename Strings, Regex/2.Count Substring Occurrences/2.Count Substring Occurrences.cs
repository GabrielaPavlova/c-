using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower(); // na malki bukvi
            string pattern = Console.ReadLine().ToLower();

            int counter = 0; // vse oshte tyrsim element
            int index = input.IndexOf(pattern);
            while (index != -1) // indeksa trqbva da e razlichen ot -1 
            {
                counter++; 
                index = input.IndexOf(pattern, index + 1); // posle tyrsi i po natatyka no natam veche go nqma 
            }
            Console.WriteLine(counter);

        }
    }
}
