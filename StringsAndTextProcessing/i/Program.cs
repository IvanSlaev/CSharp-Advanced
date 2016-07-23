using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i
{
    class Program
    {
        static string GetUnicodeString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append("\\u" + ((int)c).ToString("X").PadLeft(4, '0'));
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Console.WriteLine(GetUnicodeString(text));
        }
    }
}
