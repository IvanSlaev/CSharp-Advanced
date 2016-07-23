using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int[] list = new int[N];
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                list[i] = 1;
            }
            for (int i = 1; i < N; i++)
                for (int j = 0; j < i; j++)
                    if (numbers[i] >= numbers[j] && list[i] <= list[j] + 1)
                    {
                        list[i] = list[j] + 1;
                        if (max < list[i])
                            max = list[i];
                    }
            Console.WriteLine(N - max);
        }
    }
}
