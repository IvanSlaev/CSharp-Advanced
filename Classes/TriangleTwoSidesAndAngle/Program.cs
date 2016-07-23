using System;

namespace HeronFormulaAreaOfTriangleByThreeSides
{
    public class Triangle
    {
        public double firstSide;
        public double secondSide;
        public double angle;

        public double ConvertToRadians()
        {
            return (Math.PI / 180) * angle;
        }

        public double Area()
        {
            return firstSide * secondSide * Math.Sin(ConvertToRadians()) / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle();

            myTriangle.firstSide = double.Parse(Console.ReadLine());
            myTriangle.secondSide = double.Parse(Console.ReadLine());
            myTriangle.angle = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}", myTriangle.Area());
        }
    }
}
