using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_oop_practice_1
{
    public class App
    {
        static void Main(string[] args)
        {
            // // Create multiple student objects
            // Student student1 = new Student("Alice", 20, 3.80);
            // Student student2 = new Student("Bob", 22, 3.50);
            // Student student3 = new Student("Charlie", 19, 3.90);

            // // Display student information
            // Console.WriteLine("Student 1 Information:");
            // student1.DisplayInfo();
            // Console.WriteLine();

            // Console.WriteLine("Student 2 Information:");
            // student2.DisplayInfo();
            // Console.WriteLine();

            // Console.WriteLine("Student 3 Information:");
            // student3.DisplayInfo();
            // Console.WriteLine();

            // // Display total number of students
            // Console.WriteLine("Summary:");
            // Student.DisplayTotalStudents();

            // Create BankAccount objects
            BankAccount account1 = new BankAccount("Alice Johnson", 500.00);
            BankAccount account2 = new BankAccount("Bob Smith", 1000.00);

            // Display initial account information
            Console.WriteLine("Account 1 Information:");
            account1.DisplayAccountInfo();
            Console.WriteLine();

            Console.WriteLine("Account 2 Information:");
            account2.DisplayAccountInfo();
            Console.WriteLine();

            // Perform transactions
            Console.WriteLine("Performing transactions on Account 1...");
            account1.Deposit(200.00);
            account1.Withdraw(100.00);
            Console.WriteLine();

            Console.WriteLine("Performing transactions on Account 2...");
            account2.Deposit(300.00);
            account2.Withdraw(1500.00); // Insufficient funds
            Console.WriteLine();

            // Display updated account information
            Console.WriteLine("Updated Account 1 Information:");
            account1.DisplayAccountInfo();
            Console.WriteLine();

            Console.WriteLine("Updated Account 2 Information:");
            account2.DisplayAccountInfo();
        }
    }
}
