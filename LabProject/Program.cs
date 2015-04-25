using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Instantiating three Student objects
                Student jeferson = new Student("Jéferson", "Guimarães", new DateTime(1995, 8, 2));
                Student john = new Student("John", "Smith", new DateTime(1994, 1, 1));
                Student ana = new Student("Ana", "da Silva", new DateTime(1995, 5, 15));

                //Instantiating the Course object
                Course programmingWithCSharp = new Course("Programming with C#");

                //Adding the Student objects to the Course object
                programmingWithCSharp.Students[0] = jeferson;
                programmingWithCSharp.Students[1] = john;
                programmingWithCSharp.Students[2] = ana;

                //Instantiating Teacher object
                Teacher garry = new Teacher("Garry", "O'Brien", new DateTime(1965, 10, 22));

                //Adding the Teacher to the Course object
                programmingWithCSharp.Teachers[0] = garry;

                //Instantiating Degree object
                Degree bachelorOfScience = new Degree("Bachelor of Science");

                //Adding the Course object to the Degree object
                bachelorOfScience.Courses = programmingWithCSharp;

                //Instantiating UProgram object
                UProgram informationTechnology = new UProgram("Information Technology");

                //Adding the Degree object to the UProgram object
                informationTechnology.Degrees = bachelorOfScience;

                //Printing the name of the program and the degree it contains
                Console.WriteLine("The {0} program contains the {1} degree\n",
                    informationTechnology.Name, bachelorOfScience.Name);

                //Printing the name of the course in the degree
                Console.WriteLine("The {0} degree contains the course {1}\n",
                    bachelorOfScience.Name, programmingWithCSharp.Name);

                //Printing the number of students in the course
                //The static method getNumberOfStudents return the value of the static variable numberOfStudents
                //In the constructor the variable is incremented
                Console.WriteLine("The {0} course contains {1} student(s)\n",
                    programmingWithCSharp.Name, Student.GetNumberOfStudents());

                //Adding code to test inheritance
                Console.WriteLine("The students are:\n");

                jeferson.PrintPersonName();
                john.PrintPersonName();
                ana.PrintPersonName();

                addLineToConsole();

                Console.WriteLine("And the teacher is:\n");

                garry.PrintPersonName();

                addLineToConsole();

                Console.WriteLine("And about their tests:\n");

                jeferson.TakeTest();
                john.TakeTest();
                ana.TakeTest();

                garry.GradeTest();

            }
            catch (Exception e)
            {
                //In case any exception occurs in the program
                Console.WriteLine("An unexpected error ocurred: {0}", e.Message);
            }
            finally
            {
                //Code that'll always be executed, just printing a new line
                addLineToConsole();
            }

            Console.ReadLine(); //Just so the window doesn't automatically close after execution
        }

        static void addLineToConsole()
        {
            //Method to add a new line after a block of information, to organize info on screen
            Console.WriteLine();
        }
    }
}
