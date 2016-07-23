using System;
using System.Text;

namespace Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string subStringToCompare = Console.ReadLine();
            string holeString = Console.ReadLine();
          
            
            int counter = 0;
            for (int i = 0; i < holeString.Length - subStringToCompare.Length + 1; i++)
            {
                string sub = holeString.Substring(i, subStringToCompare.Length);
                if (string.Compare(sub, subStringToCompare, true) == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);     

        }
    }
}
