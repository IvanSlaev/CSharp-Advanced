using System;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string toReverse = Console.ReadLine();
            StringBuilder reversed = new StringBuilder(toReverse.Length);
            for (int i = 0; i < toReverse.Length; i++)
            {
                reversed.Insert(0, toReverse[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
