using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_oop_practice_1
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        static int totalStudents = 0;

        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
            totalStudents++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }

        public static void DisplayTotalStudents()
        {
            Console.WriteLine($"Total Students: {totalStudents}");
        }
    }
}
