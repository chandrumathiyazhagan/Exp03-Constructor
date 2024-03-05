# Exp03-Constructor
## Aim: 
To write a C# program to calculate the salary of an employee by passing the name, designation, noofexperience, basic salary and insurance amount through constructor.

## Algorithm:

### Step1:
Develope C# program to calculate the salary of an employee

### Step2:
et the input values from user

### Step3:
create a function "salary"

### Step4:
Display the function of employee detail with gross salary

### Step5:
Display the Output

### Step6:
End the Program.

## Program:
```python
using System;

class Employee
{
    string name;
    string designation;
    int noOfExperience;
    double basicSalary;
    double insuranceAmount;

    public Employee(string name, string designation, int noOfExperience, double basicSalary, double insuranceAmount)
    {
        this.name = name;
        this.designation = designation;
        this.noOfExperience = noOfExperience;
        this.basicSalary = basicSalary;
        this.insuranceAmount = insuranceAmount;
    }

    public double CalculateSalary()
    {
        double hra = 0.2 * basicSalary;
        double ta = 0.1 * basicSalary;
        double grossSalary = basicSalary + hra + ta;
        return grossSalary;
    }

    public void Display()
    {
        double grossSalary = CalculateSalary();
        Console.WriteLine("Employee Details:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Designation: {designation}");
        Console.WriteLine($"Experience: {noOfExperience} years");
        Console.WriteLine($"Basic Salary: {basicSalary:C}");
        Console.WriteLine($"Gross Salary: {grossSalary:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Employee Designation:");
        string designation = Console.ReadLine();

        Console.WriteLine("Employee Experience:");
        int noofexp = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Basic salary:");
        double bs = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insurance amount:");
        double insuranceamount = Convert.ToDouble(Console.ReadLine());

        Employee emp1 = new Employee(name, designation, noofexp, bs, insuranceamount);
        emp1.Display();
    }

}
```
## Output:
![image](/output.png)
## Result:
Hence, C# program to calculate the salary of an employee is executted Successfully.
