using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double squareRootOfNumber;
            try
            {
                double number = double.Parse(Console.ReadLine());
                squareRootOfNumber = Math.Sqrt(number);
                
                Console.WriteLine("{0:F3}", squareRootOfNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {   
                Console.WriteLine("Good bye");
            }
        }
    }
}
