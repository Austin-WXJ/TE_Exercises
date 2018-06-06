using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
        //Variables
        private int employeeId = 0;
        private string firstName = "";
        private string lastName = "";
        private string department = "";
        private string fullName = "";
        private double annualSalary = 0;


        //Properties
        public int EmployeeId
        {
            get
            {
                return employeeId;
            }

        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string FullName
        {
            get
            {
                return fullName = lastName + ", " + firstName;
            }
        }

        public double AnnualSalary
        {
            get
            {
                return annualSalary;
            }
            private set
            {
                annualSalary = value;
            }
        }

        //Constructors
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.employeeId = employeeId;
            this.firstName = firstName;
            LastName = lastName;
            annualSalary = salary;
        }

        //Methods
        public void RaiseSalary(double percent)
        {
            annualSalary *= (1+ percent/ 100);
        }
    }
}
