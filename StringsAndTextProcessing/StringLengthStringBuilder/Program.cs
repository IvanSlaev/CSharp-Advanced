using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLengthStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sentence = new StringBuilder();
            sentence.Append(Console.ReadLine());

            for (int i = sentence.Length; i < 20; i++)
            {
                sentence.Append('*');
            }

            Console.WriteLine(sentence.Remove(20, sentence.Length - 20));
        }
    }
}
