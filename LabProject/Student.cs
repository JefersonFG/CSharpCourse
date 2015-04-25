using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Student : Person
    {
        //Static variable to keep track of the number of students in the school
        private static int numberOfStudents = 0;

        //Constructor
        public Student(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;

            //Increment the number of students
            numberOfStudents++;
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
