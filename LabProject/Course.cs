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
        //Properties

        public string Name { get; set; }
        public Teacher[] Teachers { get; set; }
        public List<Student> StudentList { get; set; }

        //Constructor

        public Course(string name)
        {
            this.Name = name;

            //Instantiate the studentList List<T>
            this.StudentList = new List<Student>();

            //Automatically creates arrays of three for the Teachers property
            Teachers = new Teacher[3];
        }

        //Methods

        public void listStudents()
        {
            Console.WriteLine("Listing the students applying to the course:\n");

            foreach (Student student in StudentList)
            {
                Console.WriteLine("Student's name: {0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
