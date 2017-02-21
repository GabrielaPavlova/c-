using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Special_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++) ;
            {
                int sumOfDigits = 0;
                
                int digits = int.Parse(Console.ReadLine();
                while (digits < 0)
                {
                    sumOfDigits += digits % 10; // връща ни остатъка 11/7 (1) НО 11 % 7 (4) 
                    digits = digits / 10;
                }


                    bool special = (sumOfDigits == 5) || (sumOfDigits == 7);
                    Console.WriteLine("{0} -> {1}", digits, special);
                

            }
        }
    }
}
