using EmployeeManagementSystemBL;
using System;
using System.Collections.Generic;

internal class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("Enter the First Name Of Employee : ");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter the Last Name Of Employee : ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter the Age Of Employee : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the ID Of Employee : ");
            int iD = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Type Of Employee (Permanent(p)/Contract(c)) : ");
            string type1 = Console.ReadLine();
            if (type1.ToLower() == "c")
            {
                Console.WriteLine("Enter the Number Of Hours : ");
                int hours = Convert.ToInt32(Console.ReadLine());
                ContractEmployee Cemp1 = new ContractEmployee(iD, fname, lname, age, hours);
                employees.Add(Cemp1);
            }
            else if (type1.ToLower() == "p")
            {
                Console.WriteLine("Enter the Number Of Days : ");
                int days = Convert.ToInt32(Console.ReadLine());
                PermanentEmployee Pemp1 = new PermanentEmployee(iD, fname, lname, age, days);
                employees.Add(Pemp1);
            }
            else
            {
                Console.WriteLine("Enter the Correct Type");
            }

            Console.WriteLine("Do you want to add another employee? (yes/no) : ");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "yes")
            {
                break;
            }
        }

        Console.WriteLine("\n EMPLOYEE DETAILS");
        foreach (Employee emp in employees)
        {
            Console.WriteLine($"Employee ID: {emp.EmployeeID}\nEmployee Name: {emp.FirstName} {emp.LastName}\nEmployee Age: {emp.Age}");
            Console.WriteLine($"Calculated Salary: {emp.CalculateSalary()}\n");
        }
    }
}
