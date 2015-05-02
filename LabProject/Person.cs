using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Person
    {
        //Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        //Methods

        public void PrintPersonName()
        {
            Console.WriteLine("{0} {1} was born on {2}", FirstName, LastName, Birthday.ToShortDateString());
        }
    }
}
