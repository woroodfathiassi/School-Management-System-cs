using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass1
{
    internal class School
    {
        public const string SCHOOL_NAME = "Palestine School";
        private List<Student> students;
        private List<Teacher> teachers;
        private List<Course> courses;

        public School()
        {
            students = new List<Student>();
            teachers = new List<Teacher>();
            courses = new List<Course>();
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddCourse(Course course, Teacher teacher)
        {
            courses.Add(course);
            teacher.AssignCourse(course);
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("Students:");
            foreach (Student student in students)
            {
                student.GetPersonDetails();
            }
        }

        public void DisplayAllTeachers()
        {
            Console.WriteLine("Teachers:");
            foreach (Teacher teacher in teachers)
            {
                teacher.GetPersonDetails();
            }
        }

        public void DisplayAllCourses()
        {
            Console.WriteLine("Courses:");
            foreach (Course course in courses)
            {
                course.GetCourseDetails();
            }
        }
    }
}
