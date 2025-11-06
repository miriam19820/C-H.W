using System;
using System.Collections.Generic;
using System.Linq;

using Group;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Student s1 = new Student("Miriam", 1, 20, 95.5m, 12);
            Student s2 = new Student("Namma", 3, 21, 88.0m, 11);
            Student s3 = new Student("Ali", 2, 19, 92.3m, 12);

            Student s4 = (Student)s1.Clone();
            s4.Name = "Dina";
   Group<Student, Student> group = new Group<Student, Student>
            {
                Members = new List<Student>(),
                Groupleader = s1,
                MinOfNames = 2,
                MaxOfMames = 6,
                Openime = DateTime.Now
            };

     
            try
            {
                group.Add(s1);
                group.Add(s2);
                group.Add(s3);
                group.Add(s4);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding member: " + ex.Message);
            }

            Console.WriteLine("All members in the group:");
            group.PrintAllMembers();

            Console.WriteLine($"\nIs group size valid? {group.IsValidSize()}");

            group.SortMembers();
            Console.WriteLine("\nMembers after sorting by Id:");
            group.PrintAllMembers();

       
            Student found = group.FindMember(member => member.Name.StartsWith("B"));
            if (found != null)
                Console.WriteLine($"\nFound member whose name starts with B: {found}");

            
            Console.WriteLine($"\nGroup leader: {group.Groupleader}");

            Console.ReadLine();
        }
    }
}