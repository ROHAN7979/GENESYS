using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystemBL
{
    public class ContractEmployee : Employee
    {
        private int noOfHours;

        public int noOfHours1
        {
            get { return noOfHours; }
            set { noOfHours = value; }
        }

        public ContractEmployee(int EmployeeID, string fname, string lname, int age, int noOfHours) : base(EmployeeID, fname, lname, age)
        {
            this.noOfHours = noOfHours;  
        }

        public override double CalculateSalary()
        {
            double dailysalary = 800;
            return dailysalary * noOfHours;
        }
    }
}
