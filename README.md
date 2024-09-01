##Practice 1: Creating a Simple Student Management System**

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

## Practice 2: Building a Simple Bank Account System**

**Objective:** This assignment will help you practice defining classes, creating objects, using constructors, properties, and methods in C#. You will create a simple bank account system that demonstrates these concepts.

### **Assignment Instructions:**

1. **Create a Class named `BankAccount`:**
   - Define the `BankAccount` class with the following properties:
     - `AccountHolder` (string) - The name of the account holder.
     - `AccountNumber` (string) - The account number (auto-generated or manually set).
     - `Balance` (double) - The current balance of the account (should only be modified within the class).

2. **Create a Constructor for the `BankAccount` Class:**
   - The constructor should take the account holder's name and initial deposit amount as parameters.
   - It should initialize the account holder's name, set an account number, and set the balance to the initial deposit amount.

3. **Create Methods in the `BankAccount` Class:**
   - `Deposit(double amount)`: A method to deposit money into the account. Increase the balance by the deposited amount.
   - `Withdraw(double amount)`: A method to withdraw money from the account. Decrease the balance if there are sufficient funds; otherwise, display an error message.
   - `DisplayAccountInfo()`: A method to display the account holder’s name, account number, and balance.

4. **Create an `App` Class with the `Main` Method:**
   - Create at least two `BankAccount` objects using the `BankAccount` class.
   - Use the methods to deposit and withdraw money from the accounts.
   - Display the account information for each account.

### **Expected Output:**

```
Account 1 Information:
Account Holder: Alice Johnson
Account Number: ACC1000
Balance: $500.00

Account 2 Information:
Account Holder: Bob Smith
Account Number: ACC1001
Balance: $1,000.00

Performing transactions on Account 1...
Successfully deposited $200.00. New balance: $700.00
Successfully withdrew $100.00. New balance: $600.00

Performing transactions on Account 2...
Successfully deposited $300.00. New balance: $1,300.00
Invalid withdraw amount. Please ensure you have sufficient funds.

Updated Account 1 Information:
Account Holder: Alice Johnson
Account Number: ACC1000
Balance: $600.00

Updated Account 2 Information:
Account Holder: Bob Smith
Account Number: ACC1001
Balance: $1,300.00
```

### **Concepts Covered:**

1. **Class**: Definition of the `BankAccount` class.
2. **Object**: Creation of `BankAccount` objects (`account1`, `account2`).
3. **Constructor**: Initializes properties with provided values.
4. **Properties**: Public properties for account holder and private set for account number and balance.
5. **Methods**: `Deposit`, `Withdraw`, and `DisplayAccountInfo` to perform account operations.

This assignment provides a practical and engaging way for students to practice class, object creation, properties, methods, and constructors in C#.
