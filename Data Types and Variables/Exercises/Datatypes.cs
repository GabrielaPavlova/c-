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
            for (int i3 = 0; i3 < 32780; i3++)
            {
                counter3++;
                Console.WriteLine(counter3); // Стига до 32768 и след това заповча от -32768 за да изкара числата над (диапазон -32768 +32768 ) (знаков тип)    
            }
            {
                ushort counter4 = 0;
                for (int i4 = 0; i4 < 65540; i4++);
                {
                    counter4++;
                    Console.WriteLine(counter4); // Стига до 65535 и спира. Само положителни !

                }

            }

// int - 32 битов. Знаков. - + ( 2 147 483 648)
// uint - 32 битов. Беззнаков ( 4 294 967 295)
// long - 64 битов. Знаков.  ( 9 милярда)
// ulong - 64 битов. Беззнаков. (18 милярда) Най - големият ! 
// Използваме беззнаковите типове, защото всички стойности са положителни !



        }


         
          
        }
    }

