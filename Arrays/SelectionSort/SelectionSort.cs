using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
                numbers[i] = int.Parse(Console.ReadLine());
            int min = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (numbers[j] > numbers[i])
                    {
                        min = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = min;
                    }
                }
            }
            for (int i = 0; i < N; i++)
                Console.WriteLine(numbers[i]); 
        }
    }
}
