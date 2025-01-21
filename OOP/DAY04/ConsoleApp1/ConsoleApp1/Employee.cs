namespace EmployeeManagementSystemBL
{
    public class Employee
    {
        private static int numberOfEmployees;


        public int Age { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee(int employeeID, string fname, string lname, int age)
        {
            EmployeeID = employeeID;
            FirstName = fname;
            LastName = lname;
            Age = age;

        }
        public void AddEmployee(List<Employee> employees)
        {
            employees.Add(this);
        }

        public virtual double CalculateSalary()
        { return 0; }


    }
}
