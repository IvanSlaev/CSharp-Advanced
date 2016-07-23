using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemElFromArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] check = new int[N];
            for (int i = 0; i < N; i++)
                check[i] = int.Parse(Console.ReadLine());
            int counter = 1;
            int max = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                    if (check[j - 1] <= check[j])
                    {
                        counter++;
                        if (counter > max)
                            max = counter;
                    }
                counter = 1;
            }
            Console.WriteLine(N - max);
        }
    }
}
