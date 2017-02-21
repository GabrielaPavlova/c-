using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    public class BooleanVariable
    {
        public static void Main(string[] args)
        {

            string convertBool = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(convertBool);
             if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
