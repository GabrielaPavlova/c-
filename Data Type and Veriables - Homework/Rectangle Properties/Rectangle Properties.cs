using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
     public class Program
    {
        public static void Main(string[] args)
        {

            double height = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double perimetar =  2 * (height + weight);

            double area = height * weight;

            double diagonal = (height * height) + (weight * weight);

            double allDiagonal =  Math.Sqrt(diagonal); // Funkciqta za Koren v C# !!!!!!! 

       


            Console.WriteLine(perimetar);
            Console.WriteLine(area);
            Console.WriteLine(allDiagonal);



        }
    }
}
