using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N - 1];
      
            for (int i = 0; i < N - 1; i++)
                numbers[i] = i + 2;
            int max = 2;

            for (int i = 0; i < N - 1; i++)
                if (numbers[i] != 0)
                {
                    int buffer = numbers[i];
                    for (int j = i; j < N - 1; j += buffer)
                    {
                        if (i == j)
                            max = numbers[j];
                        numbers[j] = 0;
                    }
                }
            Console.WriteLine(max);
        }
    }
}
