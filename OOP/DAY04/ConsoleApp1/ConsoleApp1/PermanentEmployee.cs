using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystemBL
{
    public class PermanentEmployee : Employee
    {
        private int noOfDays;

        public int DaysWorked
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        public PermanentEmployee(int employeeID, string fname, string lname, int age, int noOfDays)
            : base(employeeID, fname, lname, age)
        {
            this.noOfDays = noOfDays;
        }

        public override double CalculateSalary()
        {
            double dailySalary = 2000;
            return noOfDays * dailySalary;
        }
    }
}
