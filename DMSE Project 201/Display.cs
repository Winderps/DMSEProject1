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
        int inputStudent;
        int inputCourse;

        public void DisplayNames(Student[] students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine("{0}) {1} {2} - {3}", counter, student.FirstName, student.LastName, student.ID);
                counter++;
            }
            DisplayCourses(students[PromptUserStudents()-1]);
        }

        public int PromptUserStudents()
        {
            Console.Write("\nChoose a students information to view: ");
            inputStudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            return inputStudent;
        }

        public void DisplayCourses(Student student)  //Method call (*Array: Student[input])
        {
            counter = 1;
            Console.WriteLine("StudentID: " + student.ID);
            Console.WriteLine("First Name: " + student.FirstName);
            Console.WriteLine("Last Name: " + student.LastName);
            foreach (Course course in student.Courses)
            {
                Console.WriteLine("{0}) {1}", counter, course.Name);
                counter++;
            }
            DisplayStudentInfo(student, student.Courses[PromptUserCourses()-1]);
        }

        public int PromptUserCourses()
        {
            Console.WriteLine("\nChoose which course you would like to view: ");
            inputCourse = Convert.ToInt32(Console.ReadLine());

            return inputCourse;
        }
        
        public Course GetCourse(List<Course> CourseList, int course)
        {
            return CourseList[course];
        }

        public void DisplayStudentInfo(Student student, Course course)
        {
            Console.WriteLine("CourseID: {0}", course.ID);
            Console.WriteLine("CourseNumber: {0}", course.Number);
            Console.WriteLine("CourseName: {0}", course.Name);
            Console.WriteLine("Credit: {0}", course.Credit);
            Console.WriteLine("Semester: {0}", course.Semster);
            Console.WriteLine("Year: {0}", course.Year);
            Console.WriteLine("CourseType: {0}", course.CourseType);
            Console.WriteLine("CourseGrade: {0}", course.Grade);
        }
    }
}