using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeronFormulaAreaOfTriangleByThreeSides
{
    public class Triangle
    {
        public double firstSide;
        public double secondSide;
        public double thirdSide;

        public void SetBaselineLengths(double firstSideLength, double secondSideLength, double thirdSideLength)
        {
            this.firstSide = firstSideLength;
            this.secondSide = secondSideLength;
            this.thirdSide = thirdSideLength;
        }
        public double Perimeter()
        {
            return (firstSide + secondSide + thirdSide) / 2;
        }
        public double Area()
        {
            return Math.Sqrt(Perimeter() * (Perimeter() - firstSide) * (Perimeter() - secondSide) * (Perimeter() - thirdSide));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.firstSide = double.Parse(Console.ReadLine());
            myTriangle.secondSide = double.Parse(Console.ReadLine());
            myTriangle.thirdSide = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", myTriangle.Area());
        }
    }
}
