using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGenerator;

namespace DMSE_Project_201
{
    struct Student
    {
        public string FirstName { get { return _firstName; } }
        private string _firstName;

        public string LastName { get { return _lastName; } }
        private string _lastName;

        public string ID { get { return _id.ToString("0-00-000"); } }
        private uint _id;

        public List<Course> Courses { get { return _courses; } }
        List<Course> _courses;

        public Student(string first, string last, uint id, List<Course> courses)
        {
            _firstName = first;
            _lastName = last;
            _id = id;
            _courses = courses;
        }

        public static Student Generate(string gender)
        {
            List<Course> c = new List<Course>();
            c.Add(Course.Generate());
            return new Student(GetName("M"), NameGenerator.GenerateLastName(), (uint)(new Random()).Next(999999), c);
        }

        static public string GetName(string gender)
        {
            switch (gender)
            {
                case "M":
                    return NameGenerator.GenerateFirstName(RandomNameGenerator.Gender.Male);
                case "F":
                    return NameGenerator.GenerateFirstName(RandomNameGenerator.Gender.Female);
                default:
                    throw new ArgumentException("Argument is not a gender!", "gender");
            }
        }
    }
}


