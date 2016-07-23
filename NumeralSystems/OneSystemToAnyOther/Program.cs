using System;
using System.Collections.Generic;

namespace OneSystemToAnyOther
{
    class Program
    {
        static long ToDecimal(string number)
        {
            long decNumber = 
            foreach (char c in number)
            {
                if ((int)c < 97)
                {
                    decNumber += ((int)c - 48) * PowerOf(power, inBase);
                    power--;
                }
                else
                {
                    decNumber += ((int)c - 87) * PowerOf(power, inBase);
                    power--;
                }
            }
        }








        public static long PowerOf(long power, int of)
        {
            long result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= of;
            }
            return result;
        }

        static long ConvertToDecimal(string number, int inBase)
        {
            int power = number.Length - 1;
            long decNumber = 0;
            foreach (char c in number)
            {
                if ((int)c < 97)
                {
                    decNumber += ((int)c - 48) * PowerOf(power, inBase);
                    power--;
                }
                else
                {
                    decNumber += ((int)c - 87) * PowerOf(power, inBase);
                    power--;
                }
            }
            return decNumber;
        }

        static string ConvertToOutSystem(long decNumber, int outBase)
        {
            List<string> outBaseNumberList = new List<string>();
            int remainder = 1;
            while (true)
            {
                if (decNumber == 0)
                    break;
                outBaseNumberList.Add((decNumber % outBase).ToString());
                remainder = (int)(decNumber % outBase);
                decNumber /= outBase;
            }
            outBaseNumberList.Reverse();
            return string.Join("", outBaseNumberList.ToArray());
        }

        static void Main(string[] args)
        {
            int inBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine().ToLower();
            int outBase = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToOutSystem(ConvertToDecimal(number, inBase), outBase));
        }
    }
}
