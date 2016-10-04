using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RandomNameGenerator;

namespace DMSE_Project_201
{
    class MainMeth
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "create")
                {
                    Student[] students = new Student[10];
                    for (int i = 0; i < 10; i++)
                    {
                        Student s = Student.Generate("M");
                        students[i] = s;
                    }
                    JsonSerializer js = new JsonSerializer();
                    StreamWriter sw = new StreamWriter("data.json");
                    js.Serialize(sw, students);
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                if (File.Exists("data.json"))
                {
                    JsonSerializer js = new JsonSerializer();
                    JsonReader sr = new JsonTextReader(new StreamReader("data.json"));
                    Student[] students = js.Deserialize<Student[]>(sr);
                    //ready to accept user input
                }
            }
        }
    }
}

