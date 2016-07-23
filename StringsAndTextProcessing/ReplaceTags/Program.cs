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

            string aOpenStart = @"<a";
            string aOpenFinish = @""">";
            string aClose = "</a>";
            
            int i = 0;
            int startIndex = 0;

           while (i < sentence.Length)
            {
                if (i == sentence.Length - 1)
                {
                    i++;
                    sen.Append(sentence.Substring(startIndex, i - startIndex));
                    
                }
                else if (String.Compare(sentence.Substring(i, 2), aOpenStart, false) == 0 && i == startIndex)
                {
                    int finishIndex = sentence.IndexOf(aOpenFinish, i + 9);
                    int close = sentence.IndexOf(aClose, i + 9);
                    string site = sentence.Substring(i + 9, finishIndex - (i + 9));
                    string siteN = sentence.Substring(finishIndex + 2, close - (finishIndex + 2));
                    sen.Append("[" + siteN + "](" + site + ")");
                    startIndex = close + 4;
                    i = close + 4;
                }
                else if (String.Compare(sentence.Substring(i, 2), aOpenStart, false) == 0 && i > startIndex)
                {
                    sen.Append(sentence.Substring(startIndex, i - startIndex));
                    int finishIndex = sentence.IndexOf(aOpenFinish, i + 9);
                    int close = sentence.IndexOf(aClose, i + 9);
                    string site = sentence.Substring(i + 9, finishIndex - (i + 9));
                    string siteN = sentence.Substring(finishIndex + 2, close - (finishIndex + 2));
                    sen.Append("[" + siteN + "](" + site + ")");
                    startIndex = close + 4;
                    i = close + 4;
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
