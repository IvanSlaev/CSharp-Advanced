using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] alphabet = new char[26];
            for (int i = 0; i < 26; i++)
                alphabet[i] = (char)(i + 97);

            foreach (char letter in word)
                Console.WriteLine(Array.IndexOf(alphabet, letter));
        }
    }
}
