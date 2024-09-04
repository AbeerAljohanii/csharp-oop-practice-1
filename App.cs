using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class App
    {
        static void Main(string[] args)
        {
            // Create multiple student objects
            Student student1 = new Student("Alice", 20, 3.80);
            Student student2 = new Student("Bob", 22, 3.50);
            Student student3 = new Student("Charlie", 19, 3.90);

            // Display student information
            Console.WriteLine("Student 1 Information:");
            student1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Student 2 Information:");
            student2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Student 3 Information:");
            student3.DisplayInfo();
            Console.WriteLine();

            // Display total number of students
            Console.WriteLine("Summary:");
            Student.DisplayTotalStudents();
        }
    }
}
