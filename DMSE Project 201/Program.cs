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
    class Program
    {
        public static ushort currentID = 0;
        static void Main(string[] args)
        {
            if (File.Exists("data.json"))
            {
                StreamReader sr = new StreamReader("data.json");
                Student[] students = JsonConvert.DeserializeObject<Student[]>(sr.ReadToEnd());
                string input = "";
                string[] inputSplit = { "" };
                Display d = new Display();
                while (inputSplit[0] != "exit")
                {
                    Console.Write(">");
                    input = Console.ReadLine();
                    inputSplit = input.Split(' ');
                    switch (inputSplit[0])
                    {
                        case "help":

                            break;
                        case "lookup":

                            break;
                        case "exit":
                            break;
                        default:
                            object result = execLINQ(input, students.ToList());
                            Type t = result.GetType().GenericTypeArguments.FirstOrDefault();
                            if (t.Equals(typeof(Student)))
                            {
                                IEnumerable<Student> returned = ((IEnumerable<Student>)result);
                                if (returned.Count() > 1)
                                {
                                    d.DisplayNames(returned.ToArray());
                                }
                                else
                                {
                                    d.DisplayCourses(returned.FirstOrDefault());
                                }
                                
                            }
                            else if (t.Equals(typeof(Course)))
                            {

                            }
                            /*if (result.Count() < 2)
                            {
                                d.DisplayStudentInfo(result.FirstOrDefault());
                            }*/
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
            return students.Where(input, students.ToArray());
            //Console.WriteLine(DynamicExpression.ParseLambda<Student, bool>(input, students).Compile().Invoke(students.ToArray()));
            
            //return CSharpScript.EvaluateAsync(input, ScriptOptions.Default.WithReferences(typeof(System.Linq.Queryable).Assembly).WithImports("System.Linq", "System.Collections.Generic"), globals: globals).Result;
        }
        
    }
    public class Globals
    {
        public List<Student> s;
        public Globals(List<Student> students)
        {
            s = students;
        }

    }
}

