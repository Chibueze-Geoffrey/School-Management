using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagement
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int GradeLevel { get; set; }
        public List<Course> EnrolledCourses { get; set; }
        public List<Grade> Grades { get; set; } 

        public Student(string name, int age, int gradeLevel, string studentID)
        {
            Name = name;
            Age = age;
            GradeLevel = gradeLevel;
            StudentID = studentID;
            EnrolledCourses = new List<Course>();
            Grades = new List<Grade>();
        }

        public void EnrollCourse(Course course)
        {
            EnrolledCourses.Add(course);
        }

        public void DropCourse(Course course)
        {
            EnrolledCourses.Remove(course);
        }
        
        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

        public double CalculateGPA()
        {
            return Grade.CalculateGPA(Grades);
        }



        public void GetStudentInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade Level: {GradeLevel}, Student ID: {StudentID}");
            Console.WriteLine($"GPA: {CalculateGPA():F2}");
        }
    }

   
}
