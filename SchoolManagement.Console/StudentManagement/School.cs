using SchoolManagement;

public class School
{
    public List<Student> Students { get; set; }
    public List<Teacher> Teachers { get; set; }
    public List<Course> Courses { get; set; }
    public List<Grade> Grades { get; set; }

    public School()
    {
        Students = new List<Student>();
        Teachers = new List<Teacher>();
        Courses = new List<Course>();
        Grades = new List<Grade>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }

    public void DisplaySchoolInfo()
    {
        Console.WriteLine("School Information:");
        Console.WriteLine("Students:");
        foreach (var student in Students)
        {
            student.GetStudentInfo();
        }
        Console.WriteLine("Teachers:");
        foreach (var teacher in Teachers)
        {
            teacher.GetTeacherInfo();
        }
        Console.WriteLine("Courses:");
        foreach (var course in Courses)
        {
            course.GetCourseInfo();
        }
    }
}