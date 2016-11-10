using RandomNameGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSE_Project_201.Core
{
    public struct Student
    {
        private static uint currentID;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        private string _firstName;

        public string LastName { get { return _lastName; } set { _lastName = value; } }
        private string _lastName;

        public string ID { get { return _id.ToString("0-00-000"); } set { _id = uint.Parse(value.Replace("-", "")); } }
        private uint _id;

        public List<Course> Courses { get { return _courses; } set { _courses = value; } }
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
            Course.ManageData();
            for (int i = 0; i < 4; i++)
            {
                c.Add(Course.Generate());
            }

            return new Student(GetName("M"), NameGenerator.GenerateLastName(), currentID++, c);
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


