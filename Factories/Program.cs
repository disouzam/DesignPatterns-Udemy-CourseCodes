using System;

namespace Factories
{
    public static class Angle
    {
        public static double ToRadians(double degree)
        {
            return (Math.PI * degree / 180.0);
        }
    }

    public class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // factory method
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        // factory method
        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        public override string ToString()
        {
            return $"{nameof(x)}:{x}, {nameof(y)}: {y}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.NewPolarPoint(1, Angle.ToRadians(Math.PI / 2));
            Console.WriteLine(point);
        }
    }
}
