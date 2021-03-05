using System;

namespace Factories
{
    class Program
    {
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
                return new Point(rho * Math.Cos(theta), rho*Math.Sin(theta));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
