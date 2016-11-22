using System;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RandomNameGenerator;
using Microsoft.CodeAnalysis.Scripting;

namespace DMSE_Project_201
{

    // Course & Student -> DmseProject201.Core
    // Some logic from program -> DmseProject201.Core
    // New Stuff -> DmseProject201.Gui

    // text box -> student ID
    // labels -> Student Info
    // data grid view -> Course Info
    // other labels -> Course summary info

    // Program -> Application (Contains methods like FindStudentById())
    //         -> DataService (Contains methods like LoadStudents())
    // (removing unusable code) + (some code that we might want)

    class Program
    {
        public static ushort currentID = 0;
        static void Main(string[] args)
        {
            if (File.Exists("data.json"))
            {
                //read in student data from data.json

                // loading the JSON for us.
                StreamReader sr = new StreamReader("data.json");
                Student[] students = JsonConvert.DeserializeObject<Student[]>(sr.ReadToEnd());
                //prepare variables to handle user input
                string input = "";
                string[] inputSplit = { "" };
                //prepare display class to display user info
                Display d = new Display();
                //Show help dialog
                Console.WriteLine("To lookup a student, type lookup [lastname] (not case sensitive). To view the list of students, use lookup all.");
                Console.WriteLine("Enter help to display this help dialog");
                while (inputSplit[0] != "exit")
                {
                    Console.Write(">");
                    input = Console.ReadLine();
                    inputSplit = input.Split(' ');
                    switch (inputSplit[0])
                    {
                        //Show help dialog
                        case "help":
                            Console.WriteLine("To lookup a student, type lookup [lastname] (not case sensitive). To view the list of students, use lookup all.");
                            break;
                        case "lookup":
                            if (inputSplit.Count() > 0)
                            {
                                //Show all students
                                if (inputSplit[1] == "all")
                                    d.DisplayNames(students);
                                else
                                {
                                    //lookup a student via LastName (case-insenitive)

 

                                    var s = students.Where(st => st.LastName.ToLower().Contains(inputSplit[1].ToLower()));
                                    if (s.Count() > 1)
                                        d.DisplayNames(s.ToArray());
                                    else if (s.Count() > 0)
                                        d.DisplayCourses(s.FirstOrDefault());
                                    else
                                        Console.WriteLine("Could not find any students matching that last name. Please try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please specify a last name!");
                            }
                            break;
                        //Exit the program.
                        case "exit":
                            break;
                        default:
                            //default to using custom LINQ queries. Probably best to avoid messing with this.

                            //Execute the user's input as a LINQ query. (Example LastName = "X" OR LastName.Contains("X"))
                            //Fields used can be any field in the Student type. Then any of their fields and methods can be used as well.
                            //FirstName.Contains(), FirstName.StartsWith(), etc.
                            object result = execLINQ(input, students.ToList());
                            IEnumerable<Student> returned = ((IEnumerable<Student>)result);
                            if (returned.Count() > 1)
                            {
                                //If more than one student matches, let the user pick
                                d.DisplayNames(returned.ToArray());
                            }
                            else
                            {
                                try
                                {
                                    //If only one student matches, display their info.
                                    d.DisplayCourses(returned.First());
                                }
                                catch
                                {
                                    //if zero students are returned, tell the user.
                                    Console.WriteLine("Sorry! Couldn't find any students matching that query!");
                                }
                            }
                            break;
                    }
                }
            }
            else
            {
                
                Student[] students = new Student[10];
                for (int i = 0; i < 10; i++)
                {
                    Student s = Student.Generate("M");
                    students[i] = s;
                }
                string json = JsonConvert.SerializeObject(students);
                StreamWriter sw = new StreamWriter("data.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Flush();
                sw.Close();
            }
        }
        public static IEnumerable<Student> execLINQ(string input, List<Student> students)
        {
            //students[0].Courses.Any("ID = 1200");
            try
            {
                return students.Where(input, students.ToArray());
            }
            catch
            {
                Console.WriteLine("Oops! That query didn't look quite right! Please try again!");
                return students.Where("LastName = \"ZZZZZZZ\"", students.ToArray());
            }
            //Console.WriteLine(DynamicExpression.ParseLambda<Student, bool>(input, students).Compile().Invoke(students.ToArray()));

            //return CSharpScript.EvaluateAsync(input, ScriptOptions.Default.WithReferences(typeof(System.Linq.Queryable).Assembly).WithImports("System.Linq", "System.Collections.Generic"), globals: globals).Result;
        }

    }
    /*public class Globals
    {
        public List<Student> s;
        public Globals(List<Student> students)
        {
            s = students;
        }

    }*/
}

