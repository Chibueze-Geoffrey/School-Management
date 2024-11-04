
using SchoolManagement;

public static class ConsoleHelper
{
    public static void DisplayHeader(string title)
    {
        Console.WriteLine("=======================================");
        Console.WriteLine($"=            {title}       =");
        Console.WriteLine("=======================================");
    }

    public static void DisplayStudentInfo(List<Student> students)
    {
        Console.WriteLine("| Student ID | Name          | Age | Grade Level |");
        Console.WriteLine("|------------|---------------|-----|-------------|");
        foreach (var student in students)
        {
            Console.WriteLine($"| {student.StudentID} | {student.Name,-12} | {student.Age}  | {student.GradeLevel}         |");
        }
        Console.WriteLine("=======================================");
    }

    public static void DisplayTeacherInfo(List<Teacher> teachers)
    {
        Console.WriteLine("| Teacher ID | Name          | Age | Department   |");
        Console.WriteLine("|------------|---------------|-----|--------------|");
        foreach (var teacher in teachers)
        {
            Console.WriteLine($"| {teacher.TeacherID} | {teacher.Name,-12} | {teacher.Age}  | {teacher.Department}  |");
        }
        Console.WriteLine("=======================================");
    }

    public static void DisplayCourseInfo(List<Course> courses)
    {
        Console.WriteLine("| Course ID | Course Name   | Credits |");
        Console.WriteLine("|------------|---------------|--------|");
        foreach (var course in courses)
        {
            Console.WriteLine($"| {course.CourseID} | {course.CourseName,-12} | {course.Credits}    |");
        }
        Console.WriteLine("=======================================");
    }

    public static void DisplayGradeInfo(List<Grade> grades)
    {
        Console.WriteLine("| Student ID | Course ID | Grade |");
        Console.WriteLine("|------------|-----------|-------|");
        foreach (var grade in grades)
        {
            Console.WriteLine($"| {grade.StudentID} | {grade.CourseID} | {grade.GradeValue}  |");
        }
        Console.WriteLine("=======================================");
    }

    public static void DisplayStudentCourseEnrollment(School school)
    {
        foreach (var student in school.Students)
        {
            Console.WriteLine($"Student: {student.Name} ({student.StudentID})");
            foreach (var course in student.EnrolledCourses)
            {
                Console.WriteLine($"- {course.CourseName} ({course.CourseID})");
            }
        }
    }

    public static void DisplayTeacherCourseAssignment(School school)
    {
        foreach (var teacher in school.Teachers)
        {
            Console.WriteLine($"Teacher: {teacher.Name} ({teacher.TeacherID})");
            foreach (var course in teacher.AssignedCourses)
            {
                Console.WriteLine($"- {course.CourseName} ({course.CourseID})");
            }
        }
    }

    public static void DisplayAllInformation(School school)
    {
        DisplayHeader("School Information");
        school.DisplaySchoolInfo();
        Console.WriteLine();

        DisplayHeader("Student Information");
        DisplayStudentInfo(school.Students);
        Console.WriteLine();

        DisplayHeader("Teacher Information");
        DisplayTeacherInfo(school.Teachers);
        Console.WriteLine();

        DisplayHeader("Course Information");
        DisplayCourseInfo(school.Courses);
        Console.WriteLine();

        DisplayHeader("Student Course Enrollment");
        DisplayStudentCourseEnrollment(school);
        Console.WriteLine();

        DisplayHeader("Teacher Course Assignment");
        DisplayTeacherCourseAssignment(school);
    }
}

