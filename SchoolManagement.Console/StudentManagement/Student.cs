using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GradeLevel { get; set; }
        public List<Course> EnrolledCourses { get; set; }

        public Student(string name, int age, int gradeLevel, string studentID)
        {
            Name = name;
            Age = age;
            GradeLevel = gradeLevel;
            StudentID = studentID;
            EnrolledCourses = new List<Course>();
        }

        public void EnrollCourse(Course course)
        {
            EnrolledCourses.Add(course);
        }

        public void DropCourse(Course course)
        {
            EnrolledCourses.Remove(course);
        }
        
        public void GetStudentInfo()
        {
            
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade Level: {GradeLevel}, Student ID: {StudentID}");
        }

    }
}
