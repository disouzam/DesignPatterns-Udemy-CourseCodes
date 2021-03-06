using System;
using static System.Console;

namespace Coding.Exercise
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }

    public class PersonFactory
    {
        private static int count = 0;

        public Person CreatePerson(string name)
        {
            var p = new Person();
            p.Id = count;
            count++;
            p.Name = name;
            return p;
        }                
    }

    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What is the name of the person to be created?");
                string s = Console.ReadLine();
                PersonFactory pf = new PersonFactory();
                var p = pf.CreatePerson(s);
                WriteLine(p);
            }
        }
    }
}
