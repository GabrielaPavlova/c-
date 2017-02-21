using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings__Regex
{
    class Campare
    {
        static void Main(string[] args)
        {
            string one = "gabriela";
            string two = "mariela";

            int result = string.Compare(one, two, true); // true ne proverqva za golemi i malki bukvi , a kogato e False zasicha kogato sa golemii !!! 

            Console.WriteLine(result); // rezultata e -1 tova znachi che one > two 

            // s tazi funkciq sravnqvame davata strinka bukva po bukva i izkarva koj e po golqm 

        }
    }
}
