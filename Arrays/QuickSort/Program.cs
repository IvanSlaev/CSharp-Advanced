using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        public static bool IfArrayIsSorted(int[] numbersToBeChecked, int lo, int hi)
        {
            int n = numbersToBeChecked.Length;
            bool isItSorted = true;
            for (int i = lo + 1; i <= hi; i++)
                if (numbersToBeChecked[i - 1] > numbersToBeChecked[i])
                    isItSorted = false;
            return isItSorted;
        }
        public static int Partition(int[] array, int lo, int hi)
        {
            int pivot = array[hi];
            int i = lo;
            int buffer;
            for (int j = 0; j < hi; j++)
            {
                if (array[j] <= pivot)
                {
                    buffer = array[i];
                    array[i] = array[j];
                    array[j] = buffer;
                    i++;
                }
            }
            buffer = array[i];
            array[i] = array[hi];
            array[hi] = buffer;
            return i;
        }
        public static void QuickSort(int[] array, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = Partition(array, lo, hi);
                bool isis = IfArrayIsSorted(array, lo, p - 1);

                if (!isis)
                {
                    QuickSort(array, lo, p - 1);
                }
                else
                {
                    if (!IfArrayIsSorted(array, p + 1, hi))
                        QuickSort(array, p + 1, hi);
                }
            }
            else
                return;
        }


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] check = new int[N];
            for (int i = 0; i < N; i++)
                check[i] = int.Parse(Console.ReadLine());
            int lo = 0;
            int hi = N - 1;
            int p;

            if (IfArrayIsSorted(check, lo, hi) == false)
            {
                QuickSort(check, lo, hi);
            }
            for (int i = 0; i < N; i++)
                Console.WriteLine(check[i]);
        }
    }
}
