using Ass1;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("welcome");
        Student std1 = new Student(1, "Ahmad", 13);
        Student std2 = new Student(2, "Mohammad", 15);
        Student std3 = new Student(3, "Ali", 14);

        Teacher tch1 = new Teacher(1, "Sami", 33);
        Teacher tch2 = new Teacher(2, "Hani", 44);

        Course c1 = new Course(1, "Math");
        c1.Teacher = tch1;
        Course c2 = new Course(2, "Science");
        c2.Teacher = tch2;
        Course c3 = new Course(3, "English");
        c3.Teacher = tch2;

        std1.EnrollInCourse(c1);
        std1.EnrollInCourse(c2);

        std2.EnrollInCourse(c1);

        std3.EnrollInCourse(c2);

        School school = new School();
        school.AddStudent(std1);
        school.AddStudent(std2);
        school.AddStudent(std3);

        school.AddTeacher(tch1);
        school.AddTeacher(tch2);

        school.AddCourse(c1, tch1 );
        school.AddCourse(c2, tch1);
        school.AddCourse(c3, tch2);

        Console.WriteLine("\nAll studenta in the School:");
        foreach (Student student in school.Students)
        {
            student.GetPersonDetails();
        }

        Console.WriteLine("\nAll Teachers in the School:");
        foreach (Teacher teacher in school.Teachers)
        {
            teacher.GetPersonDetails();
        }

        Console.WriteLine("\nAll Courses in the School:");
        foreach (Course course in school.Courses)
        {
            course.GetCourseDetails();
        }

        Console.WriteLine("\nThe School Name: "+School.SCHOOL_NAME);
        Console.WriteLine("\nThe Total Number of Teachers: " + Teacher.TotalNumOfTeacher);

    }
}
