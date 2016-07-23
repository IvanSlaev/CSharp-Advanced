using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoverOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            //input handling
            string[] size = Console.ReadLine().Split(' ');
            int n = int.Parse(size[0]);
            int m = int.Parse(size[1]);
            int[,] matrix = new int[n, m];
            int[,] bufferArr = new int[n, m];
            int starter = (n - 1) * 3;
            int buffer = starter;

            int numberOfMovements = int.Parse(Console.ReadLine());
            string[] commands = new string[numberOfMovements];
            int[] moveCount = new int[numberOfMovements];

            for (int r = 0; r < numberOfMovements; r++)
            {
                string[] commandInput = Console.ReadLine().Split(' ');
                commands[r] = commandInput[0];
                moveCount[r] = int.Parse(commandInput[1]);
            }

            //matrix innitialising
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = starter;
                    starter += 3;
                }
                buffer -= 3;
                starter = buffer;
            }

            // matrix printing
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            int k = n - 1, l = 0;
            int movementCounter = 0;
            int score = matrix[k, l];
            bufferArr[k, l] = 1;
            while (movementCounter < numberOfMovements)
            {
                switch (commands[movementCounter])
                {
                    case "RU":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k > 0 && l < m - 1)
                            {
                                k--;
                                l++;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                    case "UR":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k > 0 && l < m - 1)
                            {
                                k--;
                                l++;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                    case "DR":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k < n - 1 && l < m - 1)
                            {
                                k++;
                                l++;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                    case "RD":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k < n - 1 && l < m - 1)
                            {
                                k++;
                                l++;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                    case "DL":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k < n - 1 && l > 0)
                            {
                                k++;
                                l--;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                    case "LD":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k < n - 1 && l > 0)
                            {
                                k++;
                                l--;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                    case "UL":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k > 0 && l > 0)
                            {
                                k--;
                                l--;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                    case "LU":
                        for (int t = 0; t < moveCount[movementCounter]; t++)
                        {
                            if (k > 0 && l > 0)
                            {
                                k--;
                                l--;
                                if (bufferArr[k, l] == 0)
                                {
                                    score += matrix[k, l];
                                    bufferArr[k, l] = 1;
                                }
                            }
                        }
                        movementCounter++;
                        break;
                }
            }
            Console.WriteLine(score);


            
        }
    }
}
