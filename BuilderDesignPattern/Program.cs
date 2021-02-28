using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace BuilderDesignPattern
{
    public class Demo
    {
        public class Person
        {
            public string Name;
            public string Position;
            public override string ToString()
            {
                return $"{nameof(Name)}: {Name},{nameof(Position)}: {Position}";
            }
        }
        public class PersonInfoBuilder
        {
            protected Person person = new Person();

            public PersonInfoBuilder Called(string name)
            {
                person.Name = name;
                return this;
            }
        } 

        public class PersonJobBuilder: PersonInfoBuilder
        {
            public PersonJobBuilder WorkAsA(string position)
            {
                person.Position = position;
                return this;
            }
        }
        static void Main(string[] args)
        {
            var builder = new PersonJobBuilder();
            builder.Called("Dickson")
                .WorkAsA
        }
    }
}
