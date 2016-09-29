using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSE_Project_201
{
    class Display
    {
        int counter = 1;
        int input;

        public void DisplayNames(ref Student student)
        {
            Console.WriteLine("{0}) {1} {2}", counter, student.FirstName, student.LastName);
            counter++;
        }

        public int PromptUser()
        {
            Console.Write("\nChoose a students information to view: ");
            input = Convert.ToInt32(Console.ReadLine());

            return input;
        }

        public void DisplayStudentInfo(ref Student student)
        {
            Console.WriteLine("\nStudentID: {0}", student.ID);
            Console.WriteLine("StudentFirstName: {0}", student.FirstName);
            Console.WriteLine("StudentLastName: {0}", student.LastName);
            /*Console.WriteLine("CourseID: {0}", student.CourseId);
            Console.WriteLine("CourseNumber: {0}", student.CourseNumber);
            Console.WriteLine("CourseName: {0}", student.CourseName);
            Console.WriteLine("Credit: {0}", student.Credits);
            Console.WriteLine("Semester: {0}", student.Semester);
            Console.WriteLine("Year: {0}", student.Year);
            Console.WriteLine("CourseType: {0}", student.CourseType);
            Console.WriteLine("CourseGrade: {0}", student.CourseGrade);*/
        }
    }
}

