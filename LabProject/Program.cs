using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProject
{
    //Creating the structs for student, professor, degree, program and course

    public struct student
    {
        //Variables
        public string firstName;
        public string lastName;
        public string birthday;
        
        //Constructor
        public student(string firstName, string lastName, string birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
        }
    }

    public struct professor
    {
        //Variables
        public string firstName;
        public string lastName;
        public string birthday;

        //Constructor
        public professor(string firstName, string lastName, string birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
        }
    }

    public struct degree
    {
        //Variables
        public string name;
        public int requiredCredits;
        public int workload;

        //Constructor
        public degree(string name, int requiredCredits, int workload)
        {
            this.name = name;
            this.requiredCredits = requiredCredits;
            this.workload = workload;
        }
    }

    public struct program
    {
        //Variables
        public string name;
        public string degrees;
        public string departmentHead;

        //Constructor
        public program(string name, string degrees, string departmentHead)
        {
            this.name = name;
            this.degrees = degrees;
            this.departmentHead = departmentHead;
        }
    }

    public struct course
    {
        //Variables
        public string name;
        public string condition;

        //Constructor
        public course(string name, string condition)
        {
            this.name = name;
            this.condition = condition;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create instances of the structs

            student jeferson = new student("Jéferson", "Guimarães", "02/08/1995");
            professor garry = new professor("Garry", "O'Brien", "01/01/1965");
            degree computerEngineering = new degree("Bachelor in Computer Engineering", 156, 2640);
            program computation = new program("Computation", "Master, Ph.D.", "IT Institute");
            course softwareEngineering = new course("Software Engineering", "Required");

            //Create the students array

            student[] studentArray = new student[5];

            try
            {
                //Populate the students array

                studentArray[0] = jeferson;

                for (int x = 1; x < 5; x++)
                    studentArray[x] = new student();

                //Call a function that outputs the information of the first student

                printStudentInformation(jeferson);

                //Assign values to another student

                studentArray[1].firstName = "John";
                studentArray[1].lastName = "Smith";
                studentArray[1].birthday = "01/01/1990";

                //Output the information of the second student

                printStudentInformation(studentArray[1]);
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

        static void printStudentInformation(student pupil)
        {
            //Print the values of the variables of the student using a series of Console.WriteLine
            Console.WriteLine("Student's first name: {0}", pupil.firstName);
            Console.WriteLine("Student's last name: {0}", pupil.lastName);
            Console.WriteLine("Student's birthday: {0}", pupil.birthday);

            addLineToConsole();
        }
    }
}
