

using SchoolManagement;

public class Course
{
    public string CourseName { get; set; }
    public string CourseID { get; set; }
    public int Credits { get; set; }
    public List<Student> EnrolledStudents { get; set; }

    public Course(string courseName, string courseID, int credits)
    {
        CourseName = courseName;
        CourseID = courseID;
        Credits = credits;
        EnrolledStudents = new List<Student>();
    }

    public void EnrollStudent(Student student)
    {
        EnrolledStudents.Add(student);
    }

    public void DropStudent(Student student)
    {
        EnrolledStudents.Remove(student);
    }

    public void GetCourseInfo()
    {
        Console.WriteLine($"Course Name: {CourseName}, Course ID: {CourseID}, Credits: {Credits}");
    }
}