using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Degree
    {
        //Properties
        public string Name { get; set; }

        public Course Courses { get; set; }

        //Constructor
        public Degree(string name)
        {
            this.Name = name;
        }
    }
}
