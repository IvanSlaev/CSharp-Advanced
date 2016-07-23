using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
                numbers[i] = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            int L = 0;
            int R = N - 1;
            int m = -1;
            double maxSteps = Math.Log(N, 2);

            for (int i = 0; i < maxSteps; i++)
            {
                m = (L + R) / 2;
                if (numbers[m] > X)
                    R = m;
                else if (numbers[m] < X)
                    L = m;
                else
                    break;
                m = -1;
            }
            Console.WriteLine(m);
        }
    }
}
