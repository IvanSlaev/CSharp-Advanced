using System;
using System.Text;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder edited = new StringBuilder();

            edited.Append(text[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i - 1] != text[i])
                {
                    edited.Append(text[i]);
                }
            }
            Console.WriteLine(edited);
        }
    }
}
