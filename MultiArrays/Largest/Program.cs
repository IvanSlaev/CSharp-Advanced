using System;
using System.Collections.Generic;

namespace LargestAreaInMatrix
{
    class Program
    {
        public static string[] AllocatingNeighbours(int i, int j, int N, int M, int[,] buffer)
        {
            string[] neighboursList = new string[8];

            if (i == 0 && j == 0)
            {
                
                neighboursList[0] = i + " " + (j + 1);
                neighboursList[1] = (i + 1) + " " + (j + 1);
                neighboursList[2] = (i + 1) + " " + j;
            }
            else if (i == 0 && j > 0 && j < M - 1)
            {
                neighboursList[0] = i + " " + (j + 1);
                neighboursList[1] = (i + 1) + " " + (j + 1);
                neighboursList[2] = (i + 1) + " " + j;
                neighboursList[3] = (i + 1) + " " + (j - 1);
                neighboursList[4] = i + " " + (j - 1);
            }
            else if (i == 0 && j == M - 1)
            {
                neighboursList[0] = (i + 1) + " " + j;
                neighboursList[1] = (i + 1) + " " + (j - 1);
                neighboursList[2] = i + " " + (j - 1);
            }
            else if (i > 0 && i < N - 1 && j == 0)
            {
                neighboursList[0] = (i - 1) + " " + j;
                neighboursList[1] = (i - 1) + " " + (j + 1);
                neighboursList[2] = i + " " + (j + 1);
                neighboursList[3] = (i + 1) + " " + (j + 1);
                neighboursList[4] = (i + 1) + " " + j;
            }
            else if (i == N - 1 && j == 0)
            {
                neighboursList[0] = (i - 1) + " " + j;
                neighboursList[1] = (i - 1) + " " + (j + 1);
                neighboursList[2] = i + " " + (j + 1);
            }
            else if (i == N - 1 && j > 0 && j < M - 1)
            {
                neighboursList[0] = i + " " + (j - 1);
                neighboursList[1] = (i - 1) + " " + (j - 1);
                neighboursList[2] = (i - 1) + " " + j;
                neighboursList[3] = (i - 1) + " " + (j + 1);
                neighboursList[4] = i + " " + (j + 1);
            }
            else if (i == N - 1 && j == M - 1)
            {
                neighboursList[0] = i + " " + (j - 1);
                neighboursList[1] = (i - 1) + " " + (j - 1);
                neighboursList[2] = (i - 1) + " " + j;
            }
            else if (i > 0 && i < N - 1 && j == M - 1)
            {
                neighboursList[0] = (i + 1) + " " + j;
                neighboursList[1] = (i + 1) + " " + (j - 1);
                neighboursList[2] = i + " " + (j - 1);
                neighboursList[3] = (i - 1) + " " + (j - 1);
                neighboursList[4] = (i - 1) + " " + j;
            }
            else
            {
                neighboursList[0] = i + " " + (j + 1);
                neighboursList[1] = (i + 1) + " " + (j + 1);
                neighboursList[2] = (i + 1) + " " + j;
                neighboursList[3] = (i + 1) + " " + (j - 1);
                neighboursList[4] = i + " " + (j - 1);
                neighboursList[5] = (i - 1) + " " + (j - 1);
                neighboursList[6] = (i - 1) + " " + j;
                neighboursList[7] = (i - 1) + " " + (j + 1);
            }
            return neighboursList;

        }
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

            byte[,] buffer = new byte[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    buffer[i, j] = 0;

            int counter = 1, max = int.MinValue;


            for (int k = 0; k < N; k++)
            {
                for (int n = 0; n < M; n++)
                {
                    int i = k;
                    int j = n;
                    if (buffer[i, j] < 2)
                    {
                        buffer[i, j] = 2;
                        List<string> sequenceOfElements = new List<string>();
                        sequenceOfElements.Add(i + " " + j);
                        bool condition = true;
                        while (condition)
                        {

                            int X, Y;

                            string[] neighbourList = AllocatingNeighbours(i, j, N, M, buffer);
                            foreach (string c in neighbourList)
                            {
                                if (c != null)
                                {
                                    string[] coordinates = c.Split();
                                    X = int.Parse(coordinates[0]);
                                    Y = int.Parse(coordinates[1]);

                                    if (buffer[X, Y] < 2)
                                    {
                                        if (matrix[i, j] == matrix[X, Y])
                                        {
                                            buffer[X, Y] = 2;
                                            sequenceOfElements.Add(X + " " + Y);
                                            counter++;
                                            if (counter > max)
                                            {
                                                max = counter;
                                            }
                                        }
                                        else
                                        {
                                            buffer[X, Y] = 1;
                                        }
                                    }
                                }
                            }

                            condition = false;
                            for (int c = 0; c < sequenceOfElements.Count - 1; c++)
                            {
                                if (sequenceOfElements[c] != null)
                                {
                                    if (c == sequenceOfElements.Count - 1)
                                    {
                                        sequenceOfElements[c] = null;
                                    }
                                    condition = true;
                                    sequenceOfElements[c] = null;
                                    string[] coordinates = sequenceOfElements[c + 1].Split();
                                    i = int.Parse(coordinates[0]);
                                    j = int.Parse(coordinates[1]);
                                    break;
                                }
                            }
                        }


                        counter = 1;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
