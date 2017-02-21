using System;
using System.Numerics;

namespace Centuries
{
    public class Centuries
    {
        public static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int year = (short)(centuries * 100);
            int days = (int)(365.2422 * year);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long milliseconds = seconds * 1000;
            long microseconds = milliseconds * 1000;
            BigInteger nanoseconds = BigInteger.Multiply(microseconds,1000);

            Console.WriteLine($"{centuries} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
  }

