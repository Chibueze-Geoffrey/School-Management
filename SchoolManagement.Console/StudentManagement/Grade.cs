public class Grade
{
    public string StudentID { get; set; }
    public string CourseID { get; set; }
    public string GradeValue { get; set; }

    public Grade(string studentID, string courseID, string gradeValue)
    {
        StudentID = studentID;
        CourseID = courseID;
        GradeValue = gradeValue;
    }

    public void CalculateGPA()
    {
        
    }

    public void GetGradeInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}, Course ID: {CourseID}, Grade: {GradeValue}");
    }
}