using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal class Teacher : Person
    {
        public static int TotalNumOfTeacher = 0;
        private List<Course> courses;
        public Teacher(int id, string name, int age) : base(id, name, age)
        {
            TotalNumOfTeacher++;
            courses = new List<Course>();
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public void AssignCourse(Course course)
        {
            courses.Add(course);
        }

        public void GetAssignedCourses()
        {
            Console.WriteLine("Assigned Courses : ");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
        public override void GetPersonDetails()
        {
            Console.WriteLine("Teacher Id: " + Id + ", Name:" + Name + ", Age: " + Age + ", Admission Date: " + AdmissionDate);
        }
    }
}
