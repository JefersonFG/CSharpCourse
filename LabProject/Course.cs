using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Course
    {
        //Fields

        public ArrayList studentList;

        //Properties

        public string Name { get; set; }
        public Teacher[] Teachers { get; set; }

        //Constructor

        public Course(string name)
        {
            this.Name = name;

            //Instantiate the studentList ArrayList
            studentList = new ArrayList();

            //Automatically creates arrays of three for the Teachers property
            Teachers = new Teacher[3];
        }

        //Methods

        public void listStudents()
        {
            Console.WriteLine("Listing the students applying to the course:\n");

            //Creating a student object outside the foreach loop
            Student student;

            //Iterating with a System.Object in order to explicitly cast it after
            foreach (System.Object studentObject in studentList)
            {
                //Explicitly casting the System.Object to Student
                student = (Student) studentObject;
                Console.WriteLine("Student's name: {0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
