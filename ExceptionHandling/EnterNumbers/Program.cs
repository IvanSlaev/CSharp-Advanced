using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static int ReadNumber(int start, int end)
        {
                int number = int.Parse(Console.ReadLine());
                if (number <= start || number >= end)
                {
                    throw new Exception();
                }
            return number;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = ReadNumber(1, 100);
                }
                for (int i = 1; i < 10; i++)
                {
                    if (numbers[i] <= numbers[i - 1])
                        throw new Exception();
                }
                for (int i = 0; i < 10; i++)
                {
                    if (i == 0)
                        Console.Write("1 < {0} < ", numbers[i]);
                    else if (i == 9)
                    {
                        Console.WriteLine("{0} < 100", numbers[i]);
                    }
                    else
                    {
                        Console.Write("{0} < ", numbers[i]);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
                
            }
        }
    }
}
