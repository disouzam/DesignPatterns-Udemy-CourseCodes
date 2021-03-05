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
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
