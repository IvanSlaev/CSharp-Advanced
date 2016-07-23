using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int i = 1, j = 2;

            for (int n = 0; n < N; n++)
                numbers[n] = int.Parse(Console.ReadLine());
            int sum = numbers[0];
            int sumR = numbers[0];

            while (i < N)
            {
                sum += numbers[i];
                if (sum >= sumR)
                    sumR = sum;
                i++;
                if (i == N)
                {
                    i = j;
                    sum = 0;
                    j++;
                }
            }
            Console.WriteLine(sumR);
        }
    }
}
