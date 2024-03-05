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