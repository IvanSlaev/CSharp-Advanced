using System;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 16).ToUpper());
        }
    }
}
