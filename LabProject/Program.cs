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
            String studentFirstName;
            String studentLastName;
            String studentBirthday;
            String studentAddressLine1;
            String studentAddressLine2;
            String studentCity;
            String studentStateProvince;
            String studentCountry;
            int studentZipPostal;

            String professorFirstName;
            String professorLastName;
            String professorTeachingSubject;

            String degreeName;
            int degreeRequiredCredits;
            int degreeWorkload;

            String programName;
            String programDegrees;
            String programDepartmentHead;

            String courseName;
            String courseCondition;

            studentFirstName = "Jéferson";
            studentLastName = "Guimarães";
            studentBirthday = "02/08/1995";
            studentAddressLine1 = "Rua Joaquim Gonçalves Ledo";
            studentAddressLine2 = "Canudos";
            studentCity = "Novo Hamburgo";
            studentStateProvince = "RS";
            studentCountry = "Brazil";
            studentZipPostal = 93542500;

            professorFirstName = "Gerry";
            professorLastName = "O'Brien";
            professorTeachingSubject = "Programming with C#";

            degreeName = "Bachelor in Computer Engineering";
            degreeRequiredCredits = 156;
            degreeWorkload = 2640;

            programName = "Computation";
            programDegrees = "Master, Ph.D.";
            programDepartmentHead = "IT Institute";

            courseName = "Software Engineering";
            courseCondition = "Required";

            Console.WriteLine(studentFirstName);
            Console.WriteLine(studentLastName);
            Console.WriteLine(studentBirthday);
            Console.WriteLine(studentAddressLine1);
            Console.WriteLine(studentAddressLine2);
            Console.WriteLine(studentCity);
            Console.WriteLine(studentStateProvince);
            Console.WriteLine(studentCountry);
            Console.WriteLine(studentZipPostal);

            Console.WriteLine(professorFirstName);
            Console.WriteLine(professorLastName);
            Console.WriteLine(professorTeachingSubject);

            Console.WriteLine(degreeName);
            Console.WriteLine(degreeRequiredCredits);
            Console.WriteLine(degreeWorkload);

            Console.WriteLine(programName);
            Console.WriteLine(programDegrees);
            Console.WriteLine(programDepartmentHead);

            Console.WriteLine(courseName);
            Console.WriteLine(courseCondition);

            Console.ReadLine(); //Just so the window doesn't automatically close after execution
        }
    }
}
