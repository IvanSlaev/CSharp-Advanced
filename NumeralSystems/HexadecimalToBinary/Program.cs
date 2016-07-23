using System;

namespace HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Convert.ToInt64(number.ToLower(), 16), 2));
        }
    }
}
