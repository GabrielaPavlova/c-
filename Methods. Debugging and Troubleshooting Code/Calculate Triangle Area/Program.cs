﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(weight, height));




        }

        static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
    }
}
