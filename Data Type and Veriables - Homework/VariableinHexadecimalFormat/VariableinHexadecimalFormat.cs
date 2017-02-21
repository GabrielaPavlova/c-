using System;


namespace VariableinHexadecimalFormat
{
    public class VariableinHexadecimalFormat
    {
        public static void Main(string[] args)
        {
            // задача от шестайсетична бройна систеа да прави десетична :) правим я в началото стринг !!!! 
            string variableInHex = Console.ReadLine();
            int number = Convert.ToInt32(variableInHex, 16); // това се използва за да се преобразува

            Console.WriteLine(number);

        }
    }
}
