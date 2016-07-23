using System;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] number = new string[2];
            number = numbers.Split();
            int N = int.Parse(number[0]);
            int M = int.Parse(number[1]);
            string[] strColumns = new string[M];
            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine();
                strColumns = row.Split();
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = int.Parse(strColumns[j]);
                }
            }

            int maxSum = int.MinValue;
            int sum = 0;
            for (int n = 0; n < N - 2; n++)
            {
                for (int k = 0; k < M - 2; k++)
                {
                    for (int i = n; i < n + 3; i++)
                    {
                        for (int j = k; j < k + 3; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
