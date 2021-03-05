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

            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
