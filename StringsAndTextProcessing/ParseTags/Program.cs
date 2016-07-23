using System;
using System.Collections.Generic;
using System.Text;

namespace ParseTags
{
    class Program
    {


        static void Main(string[] args)
        {
            string sen = Console.ReadLine();

            string upOpen = "<upcase>";
            string upClose = "</upcase>";

            StringBuilder sentence = new StringBuilder();
            sentence.

            //getting indexes
            List<int> startIndexes = new List<int>();
            List<int> finishIndexes = new List<int>();
            for (int i = 0; i < sen.Length - upClose.Length + 1; i++)
            {
                if (sen.Substring(i, upOpen.Length) == upOpen)
                {
                    startIndexes.Add(i);
                }
                if (sen.Substring(i, upClose.Length) == upClose)
                {
                    finishIndexes.Add(i);
                }
            }

            //uppercasing
            string sub;
            for (int i = 0; i < startIndexes.Count; i++)
            {
                sub = sen.Substring(startIndexes[i] + 8, finishIndexes[i] - startIndexes[i] - 8);
                
                sen = sen.Replace(sub, sub.ToUpper());
            }

            //trimming
            int j = sen.Length - 9;
            while (j >= 0)
            {
                if (sen.Substring(j, upOpen.Length) == upOpen)
                {
                    sen = sen.Remove(j, 8);
                    j -= 8;
                }
                else if (sen.Substring(j, upClose.Length) == upClose)
                {
                    sen = sen.Remove(j, 9);
                    j -= 9;
                }
                else
                {
                    j--;
                }
            }
            Console.WriteLine(sen);
        }
    }
}