using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Teacher : Person
    {
        //Constructor
        public Teacher(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        //Methods
        public void GradeTest()
        {
            Console.WriteLine("The teacher {0} {1} is grading a test", FirstName, LastName);
        }
    }
}
