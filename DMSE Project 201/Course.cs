using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSE_Project_201
{
    struct Course
    {
        public string ID { get { return Name.Remove(4).ToUpper()+"-"+_id.ToString("0000"); } }
        private ushort _id;

        public string Name { get { return _name; } }
        private string _name;

        public ushort Year { get { return _year; } }
        private ushort _year;

        public Course(ushort id, string name)
        {
            _id = id;
            _name = name;
        }

        public Course Generate()
        {
            
        }
    }
}
