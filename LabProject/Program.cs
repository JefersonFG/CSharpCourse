using System;
using System.Collections;
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
                //Instantiating the variables

                Student jeferson = new Student("Jéferson", "Guimarães", new DateTime(1995, 8, 2));
                Student john = new Student("John", "Smith", new DateTime(1994, 1, 1));
                Student ana = new Student("Ana", "da Silva", new DateTime(1995, 5, 15));

                Teacher garry = new Teacher("Garry", "O'Brien", new DateTime(1965, 10, 22));

                Degree bachelorOfScience = new Degree("Bachelor of Science");

                UProgram informationTechnology = new UProgram("Information Technology");

                Course programmingWithCSharp = new Course("Programming with C#");

                //Creating the grades for the students

                jeferson.Grades.Push(10);
                jeferson.Grades.Push(10);
                jeferson.Grades.Push(9);
                jeferson.Grades.Push(9);
                jeferson.Grades.Push(10);

                john.Grades.Push(2);
                john.Grades.Push(3);
                john.Grades.Push(4);
                john.Grades.Push(3);
                john.Grades.Push(1);

                ana.Grades.Push(6);
                ana.Grades.Push(7);
                ana.Grades.Push(6);
                ana.Grades.Push(4);
                ana.Grades.Push(9);

                //Adding the Student objects to the Course object's arrayList

                programmingWithCSharp.StudentList.Add(jeferson);
                programmingWithCSharp.StudentList.Add(john);
                programmingWithCSharp.StudentList.Add(ana);

                //Assigning the object structure

                programmingWithCSharp.Teachers[0] = garry;

                bachelorOfScience.Courses = programmingWithCSharp;

                informationTechnology.Degrees = bachelorOfScience;

                //Printing the data of the structure created

                Console.WriteLine("The {0} program contains the {1} degree\n",
                    informationTechnology.Name, bachelorOfScience.Name);

                Console.WriteLine("The {0} degree contains the course {1}\n",
                    bachelorOfScience.Name, programmingWithCSharp.Name);

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

                addLineToConsole();

                //Listing the students applying to the Course

                programmingWithCSharp.listStudents();

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

            //Just so the window doesn't automatically close after execution
            Console.ReadLine();
        }

        static void addLineToConsole()
        {
            //Method to add a new line after a block of information, to organize info on screen
            Console.WriteLine();
        }
    }
}
