using System;

namespace TriangleSurfaceBySideAndAltitude
{
    public class Triangle
    {
        public double baseLine;
        public double altitude;

        public void SetBaselineLengths(double baseLineLength, double altitudeLength)
        {
            this.baseLine = baseLineLength;
            this.altitude = altitudeLength;
        }

        public double Area()
        {
            return baseLine * altitude / 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle = new Triangle();
            newTriangle.baseLine = double.Parse(Console.ReadLine());
            newTriangle.altitude = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", newTriangle.Area());
        }
    }
}
