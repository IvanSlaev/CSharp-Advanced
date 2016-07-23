using System;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] numbersN = new int[N];
            for (int i = 0; i < N; i++)
                numbersN[i] = int.Parse(Console.ReadLine());

            Array.Sort(numbersN);

            for (int i = N - 1; i > N - K - 1; i--)
                sum += numbersN[i];

            Console.WriteLine(sum);
        }
    }
}
