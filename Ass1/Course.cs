using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal class Course
    {
        private int _Id;
        private string _CourseName;
        private Teacher _Teacher;

        public Course(int id, string courseName, Teacher teacher)
        {
            _Id = id;
            _CourseName = courseName;
            _Teacher = teacher;
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string CourseName
        {
            get { return _CourseName; }
            set { _CourseName = value; }
        }

        public Teacher Teacher
        {
            get { return _Teacher; }
            set
            {
                _Teacher = value;
            }
        }

        public void GetCourseDetails()
        {
            Console.WriteLine("Course Id: " + _Id + ", Name: " + _CourseName + ", Teacher: " + _Teacher.Name);
        }
    }
}
