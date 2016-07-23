using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
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
            int counter = 1, max = 0, k, n;


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                        counter++;
                    else
                        counter = 1;
                    if (counter > max)
                        max = counter;
                }
                counter = 1;
            }
            counter = 1;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N - 1; j++)
                {
                    if (matrix[j, i] == matrix[j + 1, i])
                        counter++;
                    else
                        counter = 1;
                    if (counter > max)
                        max = counter;
                }
                counter = 1;
            }
            counter = 1;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < M - 1; j++)
                {
                    k = i;
                    n = j;
                    while (k < N - 1 && n < M - 1)
                    {
                        if (matrix[k, n] == matrix[k + 1, n + 1])
                            counter++;
                        else
                            counter = 1;
                        if (counter > max)
                            max = counter;
                        k++;
                        n++;
                    }
                    counter = 1;
                }
                counter = 1;
            }
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < M; j++)
                {
                    k = i;
                    n = j;
                    while (k < N - 1 && k > 0 &&  n < M && n > 0)
                    {
                        if (matrix[k, n] == matrix[k + 1, n - 1])
                            counter++;
                        else
                            counter = 1;
                        if (counter > max)
                            max = counter;
                        k++;
                        n--;
                    }
                    counter = 1;
                }
                counter = 1;
            }
            Console.WriteLine(max);
        }
    }
}
