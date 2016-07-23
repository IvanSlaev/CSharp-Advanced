using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split('.');
            StringBuilder newtext = new StringBuilder();

            foreach (string sentence in text)
            {
                bool printIt = false;
                string[] words = sentence.Split(' ');
                foreach (string word in words)
                {
                    if (String.Compare(word, keyword, true) == 0)
                    {
                        printIt = true;
                    }
                }
                if (printIt)
                {
                    newtext.Append(sentence + '.');
                }
            }
            Console.WriteLine(newtext.ToString().Trim());
        }
    }
}
