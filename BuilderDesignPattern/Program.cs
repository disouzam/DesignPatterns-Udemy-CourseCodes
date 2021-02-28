using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BuilderDesignPattern
{
    public class Person
    {
        public string Name, Position;
    }
    public sealed class PersonBuilder
    {
        private readonly List<Func<Person, Person>> actions
            = new List<Func<Person, Person>>();
    }
    public class Demo
    {
        static void Main(string[] args)
        {

        }
    }
}
