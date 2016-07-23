using System;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine((Convert.ToInt64(number.ToLower(), 16)));
        }
    }
}
