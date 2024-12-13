using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal class Student : Person
    {
        private List<Course> courses;

        public Student(int id, string name, int age) : base(id, name, age)
        {
            courses = new List<Course>();
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public void EnrollInCourse(Course course)
        {
            courses.Add(course);
        }

        public void GetEnrolledCourses()
        {
            Console.WriteLine("Enrolled Courses : ");
            foreach (Course course in courses)
            {
                Console.WriteLine(course.CourseName);
            }
        }
        public override void GetPersonDetails()
        {
            Console.WriteLine("Student Id: " + Id + ", Name:" + Name + ", Age: " + Age + ", Admission Date: " + AdmissionDate);
        }
    }
}
