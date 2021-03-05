using System;

namespace Factories
{
    class Program
    {
        public class Point
        {
            private double x, y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public Point(double rho, double theta)
            {
                this.x = rho * Math.Cos(theta);
                this.y = rho * Math.sin(theta); ;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
