using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Double_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            double size = 3.99;
            int intSize = (int)size; // Връща 3... зактъгля тоест маха всичко след десетичната запетайка
            Console.WriteLine(intSize);

        }
    }
}
