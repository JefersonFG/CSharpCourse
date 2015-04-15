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
            //Creating all variables to be used in the program

            string studentFirstName;
            string studentLastName;
            string studentBirthday;

            string professorFirstName;
            string professorLastName;
            string professorBirthday;

            string degreeName;
            int degreeRequiredCredits;
            int degreeWorkload;

            string programName;
            string programDegrees;
            string programDepartmentHead;

            string courseName;
            string courseCondition;

            try
            {
                //Getting information on all fields created
                //All variables are out so their values reflect on the original variables in the main method
                //The get methods will also call methods to print the values on the screen

                getStudentInformation(out studentFirstName, out studentLastName, out studentBirthday);
                getProfessorInformation(out professorFirstName, out professorLastName, out professorBirthday);
                getDegreeInformation(out degreeName, out degreeRequiredCredits, out degreeWorkload);
                getProgramInformation(out programName, out programDegrees, out programDepartmentHead);
                getCourseInformation(out courseName, out courseCondition);

                //Methods not implemented, a NotImplementedException will be thrown here

                validateBirthday(studentBirthday);
                validateBirthday(professorBirthday);
            }
            catch (NotImplementedException e)
            {
                //validateBirthday will throw this exception
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                //In case any other exception occurs in the program
                Console.WriteLine("An unexpected error ocurred");
            }

            Console.ReadLine(); //Just so the window doesn't automatically close after execution
        }

        static void addLineToConsole()
        {
            //Method to add a new line after a block of information, to organize info on screen
            Console.WriteLine();
        }

        static void getStudentInformation(out string firstName, out string lastName, out string birthday)
        {
            //Get the student's information

            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the student's birthday: ");
            birthday = Console.ReadLine();

            addLineToConsole();

            //Call the method to print the student's information to the console

            printStudentInformation(firstName, lastName, birthday);
        }

        static void getProfessorInformation(out string firstName, out string lastName, out string birthday)
        {
            //Get the professor's information

            Console.WriteLine("Enter the professor's first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the professor's last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the professor's birthday: ");
            birthday = Console.ReadLine();

            addLineToConsole();

            //Call the method to print the professor's information to the console

            printProfessorInformation(firstName, lastName, birthday);
        }

        static void getDegreeInformation(out string name, out int requiredCredits, out int workload)
        {
            //Get the degree's information

            //Variable for handling wrong input values
            bool result;

            Console.WriteLine("Enter the degree's name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the degree's required credits: ");
            result = Int32.TryParse(Console.ReadLine(), out requiredCredits);

            //Verify input value, if not valid prompt the user to enter a valid number

            if (!result)
            {
                do
                {
                    Console.WriteLine("Invalid input, please insert a valid number: ");
                    result = Int32.TryParse(Console.ReadLine(), out requiredCredits);
                } while (!result);
            }

            Console.WriteLine("Enter the degree's workload: ");
            result = Int32.TryParse(Console.ReadLine(), out workload);

            //Same code for verifying the input value

            if (!result)
            {
                do
                {
                    Console.WriteLine("Invalid input, please insert a valid number: ");
                    result = Int32.TryParse(Console.ReadLine(), out workload);
                } while (!result);
            }

            addLineToConsole();

            //Call the method to print the degree's information to the console

            printDegreeInformation(name, requiredCredits, workload);
        }

        static void getProgramInformation(out string name, out string degrees, out string departmentHead)
        {
            //Get the program's information

            Console.WriteLine("Enter the program's name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the program's degrees: ");
            degrees = Console.ReadLine();

            Console.WriteLine("Enter the program's department head: ");
            departmentHead = Console.ReadLine();

            addLineToConsole();

            //Call the method to print the program's information to the console

            printProgramInformation(name, degrees, departmentHead);
        }

        static void getCourseInformation(out string name, out string condition)
        {
            //Get the course's information

            Console.WriteLine("Enter the course's name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the course's condition: ");
            condition = Console.ReadLine();

            addLineToConsole();

            //Call the method to print the program's information to the console

            printCourseInformation(name, condition);
        }

        static void validateBirthday(string birthday)
        {
            //Method not yet implemented, throws exception when called
            throw new NotImplementedException();
        }

        static void printStudentInformation(string firstName, string lastName, string birthday)
        {
            //Output to console the student information

            Console.WriteLine("The student {0} {1} was born on: {2}", firstName, lastName, birthday);

            addLineToConsole();
        }

        static void printProfessorInformation(string firstName, string lastName, string birthday)
        {
            //Output to console the professor information

            Console.WriteLine("The professor {0} {1} was born on: {2}", firstName, lastName, birthday);

            addLineToConsole();
        }

        static void printDegreeInformation(string name, int requiredCredits, int workload)
        {
            //Output to console the degree information

            Console.WriteLine("The degree {0} has {1} required credits and a worload of {2} hours",
                name, requiredCredits, workload);

            addLineToConsole();
        }

        static void printProgramInformation(string name, string degrees, string departmentHead)
        {
            //Output to console the program information

            Console.WriteLine("The program {0} has the following degrees: {1} " + 
                " and its department head is {2}", name, degrees, departmentHead);

            addLineToConsole();
        }

        static void printCourseInformation(string name, string condition)
        {
            //Output to console the course information

            Console.WriteLine("The condition of the course {0} is {1}", name, condition);

            addLineToConsole();
        }
    }
}
