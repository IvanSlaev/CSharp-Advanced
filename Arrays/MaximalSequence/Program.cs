using System;

namespace MaximalSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int counter = 1;
            int maxNumsInSec = 1;

            for (int i = 0; i < N; i++)
                numbers[i] = int.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    counter++;
                    if (counter > maxNumsInSec)
                    {
                        maxNumsInSec = counter;
                        continue;
                    }
                    else
                    {
                        continue;
                    }

                }
                counter = 1;
            }
            Console.WriteLine(maxNumsInSec);
        }
    }
}
