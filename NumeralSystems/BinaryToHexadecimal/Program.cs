using System;

namespace BinaryToHexadecimal
{

    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToString(Convert.ToInt64(number, 2), 16).ToUpper());
        }
    }
}
