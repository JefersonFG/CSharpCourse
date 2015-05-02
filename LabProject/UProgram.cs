using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class UProgram
    {
        //Properties

        public string Name { get; set; }
        public Degree Degrees { get; set; }

        //Constructor

        public UProgram(string name)
        {
            this.Name = name;
        }
    }
}
