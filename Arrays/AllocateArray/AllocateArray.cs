using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = i * 5;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
