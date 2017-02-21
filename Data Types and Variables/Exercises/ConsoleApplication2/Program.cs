using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пробване на всички типове данни 
            byte counter = 0; 
            for (int i = 0; i < 260; i++)
            {
                counter++;
                Console.WriteLine(counter);
            }
            // Стига до числото 255 и спира (само Положителни) (0 do 256) 

            sbyte counter2 = 0;
            for (int i2 = 0; i2 < 130; i2++)
            {
                counter2++;
                Console.WriteLine(counter2); // Стига до 127 и започва да брои отначало от -127 (диапазон -127 + 127 (знаков тип)

            }
            short counter3 = 0;
            for (int i3 =-0; i3< 32780; i3++)
            {
                counter3++;
                Console.WriteLine(counter3);
            }            
        }
    }
}
