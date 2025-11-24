using System;

namespace Lesson7
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

      
        public Person() { }

        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString() => $"{Id} - {Name} - {Age}";
    }
}