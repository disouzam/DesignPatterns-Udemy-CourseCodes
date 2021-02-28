using System;
using System.Collections.Generic;
using System.Linq;
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

        public PersonBuilder Called(string name) => Do(p => p.Name = name);

        public PersonBuilder Do(Action<Person> action)
            => AddAction(action);

        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));

        private PersonBuilder AddAction(Action<Person> action)
        {
            actions.Add(p => { action(p);
                return p;
            });
            return this;
        }
    }

    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorksAs
            (this PersonBuilder builder, string position)
            => builder.Do(p => p.Position = position);
    }
    public class Demo
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .Called("Sarah")
                .WorksAs("Developer")
                .Build();

            WriteLine(person);



        }
    }
}
