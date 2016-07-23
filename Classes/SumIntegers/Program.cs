using System;

namespace SumIntegers
{
    public class Sum
    {
        public string sequance;

        public long[] ToIntegers()
        {
            string[] numbers = sequance.Split(' ');
            long[] integerNumbers = new long[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                integerNumbers[i] = long.Parse(numbers[i]);
            }
            return integerNumbers;
        }

        public long SumOfSequence()
        {
            long sum = 0;
            foreach (int number in ToIntegers())
            {
                sum += number;
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sum myString = new Sum();

            myString.sequance = Console.ReadLine();

            Console.WriteLine(myString.SumOfSequence());
        }
    }
}
