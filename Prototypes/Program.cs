namespace Prototypes.Coding.Exercise
{
    public class Point
    {
        public int X, Y;
    }

    public class Line
    {
        public Point Start, End;

        public Line DeepCopy()
        {
            Line nl = new Line();
            nl.Start = new Point();
            nl.Start.X = Start.X;
            nl.Start.Y = Start.Y;

            nl.End = new Point();
            nl.End.X = End.X;
            nl.End.Y = End.Y;
            return nl;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
