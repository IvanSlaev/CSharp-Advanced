using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(number, 2));
        }
    }
}
