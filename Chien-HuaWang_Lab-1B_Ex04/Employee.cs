using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien_HuaWang_Lab_1B_Ex04
{
    class Employee
    {
        public double Salary { get; set; }
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // end property
        public Employee(int id, string firstName, string lastName, double salary)
        {
            EmployeeID = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        // end constructor 
        public override string ToString()
        {
            return String.Format($"\nEmployee-ID : {this.EmployeeID}\nName   : {this.FirstName} {this.LastName}\nSalary : {this.Salary,1:c1}");
        }
        // end overriding of ToString() method
    }
}
