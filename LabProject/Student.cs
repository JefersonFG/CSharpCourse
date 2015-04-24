using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Student
    {
        //Static variable to keep track of the number of students in the school
        private static int numberOfStudents = 0;

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;

            //Increment the number of students
            numberOfStudents++;
        }

        //Methods
        public static int getNumberOfStudents()
        {
            return numberOfStudents;
        }
    }
}
