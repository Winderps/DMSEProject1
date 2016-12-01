using DMSE_Project_201.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dmse_Project_201.Core
{
    public class Logic //decisions
    {
        public Student[] LoadStudentFromJson()
        {
            if (!File.Exists("data.json"))
            {
                CreateJson();
            }

            StreamReader sr = new StreamReader("data.json");
            Student[] students = JsonConvert.DeserializeObject<Student[]>(sr.ReadToEnd());

            return students;
        }

        public void CreateJson()
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

        public Student SearchByID(Student[] student, string ID)
        {
            var s = student.FirstOrDefault(st => st.ID.Contains(ID));

            return s;
        }


        public double PercentComplete(IEnumerable<Course> courses)
        {
            var incompleteGrades = new[] { "F", "W", "I" };
            return courses
                .Select(c => incompleteGrades.Contains(c.Grade) ? 0 : 100)
                .DefaultIfEmpty()
                .Average(c => c);
            
        }




    }
}
