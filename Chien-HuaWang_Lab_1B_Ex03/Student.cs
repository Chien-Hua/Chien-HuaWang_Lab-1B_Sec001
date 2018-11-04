using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chien_HuaWang_Lab_1B_Ex03
{
    class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // end property

        public Student(int id, string firstName, string lastName)
        {
            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
        }
        // end constructor
        public override string ToString()
        {
            return String.Format($"\nID  : {this.StudentId}\nName: {this.FirstName} {this.LastName}\n");
        }
        // end overriding of ToString() method
    }
}
