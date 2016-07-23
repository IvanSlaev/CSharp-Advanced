using System;
using System.Linq;

class IntegerCalculations
{
    static void Main(string[] args)
    {
        int[] arrNum = Console.ReadLine()
                  .Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(item => int.Parse(item))
                  .ToArray();

        PrintMinElement(arrNum);
        PrintMaxElement(arrNum);
        PrintAverage(arrNum);
        PrintSumOfNumbers(arrNum);
        PrintProduct(arrNum);
    }

    static void PrintMinElement(int[] arrNumbers)
    {
        Console.WriteLine(arrNumbers.Min());
    }

    static void PrintMaxElement(int[] arrNumbers)
    {
        Console.WriteLine(arrNumbers.Max());
    }

    static void PrintAverage(int[] arrNumbers)
    {
        Console.WriteLine(String.Format("{0:F2}", (arrNumbers.Average())));
    }

    static void PrintSumOfNumbers(int[] arrNumbers)
    {
        Console.WriteLine(arrNumbers.Sum());
    }

    static void PrintProduct(int[] arrNumers)
    {
        long product = 1;

        for (int i = 0; i < arrNumers.Length; i++)
        {
            product *= arrNumers[i];
        }

        Console.WriteLine(product);
    }
}