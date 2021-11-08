using System;

namespace IntroClassesCs
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            Person person = Person.Parse("Masen");
            //person.Name = "Masen";
            person.Introduce("Austin");
        }
    }
}
