using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTagsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            StringBuilder sen = new StringBuilder();

            string upOpen = "<upcase>";
            string upClose = "</upcase>";

            int i = 0;
            int startIndex = 0;
            
            while (i < sentence.Length)
            {
                if (i > sentence.Length - 9)
                {
                    sen.Append(sentence.Substring(startIndex, sentence.Length - startIndex));
                    break;
                }
                else if (String.Compare(sentence.Substring(i, 8), upOpen, false) == 0 && i == startIndex)
                {
                    startIndex = i + 8;
                    i += 8;
                }
                else if (String.Compare(sentence.Substring(i, 8), upOpen, false) == 0 && i > startIndex)
                {
                    sen.Append(sentence.Substring(startIndex, i - startIndex));
                    startIndex = i + 8;
                    i += 8;
                }
                else if (String.Compare(sentence.Substring(i, 9), upClose, false) == 0)
                {
                    sen.Append(sentence.Substring(startIndex, i - startIndex).ToUpper());
                    startIndex = i + 9;
                    i += 9;
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(sen);
        }
    }
}
