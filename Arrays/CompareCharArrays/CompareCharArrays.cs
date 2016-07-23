using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            string firstArr = Console.ReadLine();
            string secondArr = Console.ReadLine();
            string result = "=";

            if (firstArr.Length < secondArr.Length)
                result = "<";
            else if (firstArr.Length > secondArr.Length)
                result = ">";
            else
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] < secondArr[i])
                    {
                        result = "<";
                        break;
                    }
                    else if (firstArr[i] > secondArr[i])
                    {
                        result = ">";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
