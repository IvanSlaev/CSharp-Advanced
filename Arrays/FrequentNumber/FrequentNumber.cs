using System;
using System.Linq;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int[] counters = new int[N];

            for (int i = 0; i < N; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            for (int j = 0; j < N; j++)
                for (int i = 0; i < N; i++)
                    if (numbers[j] == numbers[i])
                        counters[j]++;

            int position = Array.IndexOf(counters, counters.Max());

            Console.WriteLine("{0} ({1} times)", numbers[position], counters[position]);
        }
    }
}
