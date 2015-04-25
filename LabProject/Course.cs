using System;
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

        public Student[] Students { get; set; }
        public Teacher[] Teachers { get; set; }

        //Constructor
        public Course(string name)
        {
            this.Name = name;

            //Automatically creates arrays of three for the students and teachers properties
            Students = new Student[3];
            Teachers = new Teacher[3];
        }
    }
}
