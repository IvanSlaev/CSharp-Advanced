using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] unsortedArr = new int[N];
            int[] sortedArr = new int[N];
            for (int i = 0; i < N; i++)
                unsortedArr[i] = int.Parse(Console.ReadLine());
            int j, l;
            
            for (int width = 1; width < N; width = 2 * width)
            {
                for (int i = 0; i < N; i++)
                {
                    j = Math.Min(i + width, N);
                    l = Math.Min(i + 2 * width, N);
                    for (int k = i; k < l; k++)
                    {
                        if (i < j && (j >= l || unsortedArr[i] <= unsortedArr[j]))
                        {
                            sortedArr[k] = unsortedArr[i];
                            i++;
                        }
                        else
                        {
                            sortedArr[k] = unsortedArr[j];
                            j++;
                        }
                    }
                }
            }
            for (int i = 0; i < N; i++)
                Console.WriteLine(sortedArr[i]);
        }
    }
}
