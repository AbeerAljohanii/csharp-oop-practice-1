### **Assignment: Creating a Simple Student Management System**

**Objective:** This assignment is designed to help you understand the concepts of classes, objects, constructors, methods, and static members in C#. You will create a simple student management system that demonstrates these concepts.

### **Assignment Instructions:**

1. **Create a Class named `Student`:**

   - Define the `Student` class with the following properties:
     - `Name` (string) - Name of the student.
     - `Age` (int) - Age of the student.
     - `Grade` (double) - Grade of the student.
   - Add a static member to keep track of the total number of students created.

2. **Create a Constructor for the `Student` Class:**

   - The constructor should take the student's name, age, and grade as parameters and initialize the properties accordingly.
   - Increment the static member that tracks the number of students whenever a new student object is created.

3. **Create a Method in the `Student` Class:**

   - Add a method named `DisplayInfo` that prints the student's details in a formatted manner.

4. **Create a Static Method in the `Student` Class:**

   - Add a static method named `DisplayTotalStudents` to display the total number of students created.

5. **Create an `App` Class with the `Main` Method:**
   - Create multiple student objects using the `Student` class.
   - Call the methods of each student object to display their details.
   - Use the static method to display the total number of students.

### **Expected Output:**

```
Student 1 Information:
Student Name: Alice
Age: 20
Grade: 3.80

Student 2 Information:
Student Name: Bob
Age: 22
Grade: 3.50

Student 3 Information:
Student Name: Charlie
Age: 19
Grade: 3.90

Summary:
Total Students: 3
```

### **Concepts Covered:**

1. **Class**: Definition of the `Student` class with properties.
2. **Object**: Creation of `Student` objects (`student1`, `student2`, `student3`).
3. **Constructor**: Initializes properties and increments the student count.
4. **Method**: `DisplayInfo()` method to show student details.
5. **Static Member**: `totalStudents` to keep track of all students.
6. **Static Method**: `DisplayTotalStudents()` to show the total number of students.

This assignment provides a practical, hands-on approach to understanding how classes, objects, constructors, methods, and static members work together in C#.
