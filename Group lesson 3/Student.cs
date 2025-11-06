using System;

namespace Group
{
    public class Student : IComparable<Student>, ICloneable
    {
        public string Name { get; set; } = "";
        public int Id { get; set; }
        public int Age { get; set; }
        public decimal Marks { get; set; }
        public int Grade { get; set; }
        public Student(string name, int id, int age, decimal marks, int grade)
        {
            Name = name;
            Id = id;
            Age = age;
            Marks = marks;
            Grade = grade;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}, Age: {Age}, Marks: {Marks}, Grade: {Grade}";
        }
        public int CompareTo(Student other)
        {
            if (other == null) return 1;
            return this.Id.CompareTo(other.Id);
        }
        public object Clone()
        {
            return new Student(this.Name, this.Id, this.Age, this.Marks, this.Grade);
        }
    }
}
