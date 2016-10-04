using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSE_Project_201
{
    struct Course
    {
        public int ID { get { return _id; } }
        private int _id;

        public string Name { get { return _name; } }
        private string _name;

        public string Number { get { return Name.Remove(4).ToUpper() + "-" + _number.ToString("0000"); } }
        private int _number;

        public string Credit { get { return "0" + Convert.ToString(_credit); } }
        private string _credit;

        public string Semster { get { return _semester; } }
        private string _semester;

        public string Year { get { return "201" + _year; } }
        private string _year;

        public string CourseType { get { return _courseType; } }
        private string _courseType;

        public string Grade { get { return _grade; } }
        private string _grade;

        static List<string> names = new List<string>();     //Lists holds avaliable values for assigning

        static List<string> semesters = new List<string>();

        static List<string> types = new List<string>();

        static List<string> grades = new List<string>();

        static List<int> ids = new List<int>();

        static Random rnd = new Random();

        static int holdId; //Holds Id for reference

        static int scope = 0;



        public Course(int id, string name, int number, string credit, string semester, string year, string courseType, string grade) //Course Contructor
        {
            _id = id;
            _name = name;
            _number = number;
            _credit = credit;
            _semester = semester;
            _year = year;
            _courseType = courseType;
            _grade = grade;
        }

        public static Course Generate() //Generates Course
        {
            return new Course(RandomId(), IdToName(holdId), holdId, Convert.ToString((int)(new Random()).Next(1, 6)), semesters[(int)(new Random()).Next(0, 4)], 
                Convert.ToString((int)(new Random()).Next(1, 7)), IdToType(holdId), grades[(int)(new Random()).Next(0, 7)]);
        }

        static public void ManageData()
        {
            Options();
        }

        static int RandomId() //Get random ID and returns it.
        {
            holdId = ids[(int)(rnd).Next(0, scope)];
            return holdId;
            
        }

        static void Options() //Creates Classes Id's, Semester and Grades
        {
            ids.Clear();
            scope = 12;

                //Core
                ids.Add(1300);       //Id's Must be Unique for each class
                ids.Add(1310);
                ids.Add(1320);
                ids.Add(1330);

                //General Elective
                ids.Add(1500);
                ids.Add(1600);
                ids.Add(1700);
                ids.Add(1800);

                //Electives
                ids.Add(1200);
                ids.Add(1210);
                ids.Add(1220);
                ids.Add(1230);

                //Semesters
                semesters.Add("Spring");
                semesters.Add("Summer");
                semesters.Add("Fall");
                semesters.Add("Winter");

                //Grades
                grades.Add("A");
                grades.Add("B");
                grades.Add("C");
                grades.Add("D");
                grades.Add("F");
                grades.Add("I");
                grades.Add("W");

                //Stops from repeating steps
        }

        static public string IdToName(int id) //Uses ID to assign appropriate class name
        {
            ids.Remove(id);
            --scope;

            switch (id)
            {
                case 1300:
                    return "Java Programming 101";
                case 1310:
                    return "C# Programming 101";
                case 1320:
                    return "Swift Programming 101";
                case 1330:
                    return "Mobile Programming 101";
                case 1500:
                    return "English";
                case 1600:
                    return "Math";
                case 1700:
                    return "History";
                case 1800:
                    return "Science";
                case 1200:
                    return "Theater";
                case 1210:
                    return "Band";
                case 1220:
                    return "Basket Weaving";
                case 1230:
                    return "Sculpting";
                default:
                    throw new ArgumentException("This is not a valid ID");
                
            }
        }
        static public string IdToType(int id) //Uses ID to assign appropriate class type
        {
            switch (id)
            {
                case 1300:
                case 1310:
                case 1320:
                case 1330:
                    return "Core";
                case 1500:
                case 1600:
                case 1700:
                case 1800:
                    return "General Education";
                case 1200:
                case 1210:
                case 1220:
                case 1230:
                    return "Elective";
                default:
                    throw new ArgumentException("This is not a valid ID!");
            }
        }
    }
}
