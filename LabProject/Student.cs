using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Student : Person
    {
        //Fields

        //Static variable to keep track of the number of students in the school
        private static int numberOfStudents = 0;

        public Stack grades;

        //Constructors

        public Student(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;

            //Increment the number of students
            numberOfStudents++;

            //Instantiate the grades object
            grades = new Stack();
        }

        //Methods

        public static int GetNumberOfStudents()
        {
            return numberOfStudents;
        }

        public void TakeTest()
        {
            Console.WriteLine("The student {0} {1} is taking a test", FirstName, LastName);
        }
    }
}
