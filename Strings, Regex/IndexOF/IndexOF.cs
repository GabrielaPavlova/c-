using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOF
{
    class IndexOF
    {
        static void Main(string[] args)
        {
            string one = "baba";
            string two = "dqdo";

            int search = one.IndexOf("a");  // pokazva na koe mqsto se namira simvola 
            int search2 = one.LastIndexOf("b"); // pokazva poslednoto mqsto na koeto go namira 
            Console.WriteLine(search);

           // ako vyrne -1 ne go namira
        }
    }
}
