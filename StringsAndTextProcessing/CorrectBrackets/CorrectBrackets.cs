using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string sequance = Console.ReadLine();
            int opening = 0;
            int closing = 0;

            foreach (char charachter in sequance)
            {
                if (charachter == '(')
                {
                    opening++;
                }
                else if (charachter == ')')
                {
                    closing++;
                }
            }
            bool ifClosingAndOpenningIsEqual = opening == closing;

            Console.WriteLine(ifClosingAndOpenningIsEqual ? "Correct" : "Incorrect");
        }
    }
}
