using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] firstSetOfNumbers = new int[N];
            int[] secondSetOfNumbers = new int[N];

            for (int i = 0; i < N; i++)
                firstSetOfNumbers[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
                secondSetOfNumbers[i] = int.Parse(Console.ReadLine());
            string result = "Equal";

            for (int i = 0; i < N; i++)
                if (firstSetOfNumbers[i] != secondSetOfNumbers[i])
                    result = "Not equal";
            Console.WriteLine(result);
        }
    }
}
