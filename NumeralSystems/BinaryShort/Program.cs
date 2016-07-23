using System;

namespace BinaryShort
{
    class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}
