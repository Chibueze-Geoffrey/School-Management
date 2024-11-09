public class Grade
{
    public string StudentID { get; set; }
    public string CourseID { get; set; }
    public double Score { get; set; }
    public double GradePoint { get; private set; }

    public Grade(string studentID, string courseID, double score)
    {
        StudentID = studentID;
        CourseID = courseID;
        Score = score;
        GradePoint = CalculateGradePoint(score);
    }

    // Maps score ranges to grade points
    private double CalculateGradePoint(double score)
    {
        if (score >= 90) return 4.0;    // A
        if (score >= 80) return 3.0;    // B
        if (score >= 70) return 2.0;    // C
        if (score >= 60) return 1.0;    // D
        return 0.0;                     // F
    }

    public static double CalculateGPA(List<Grade> grades)
    {
        if (grades.Count == 0) return 0.0;

        double totalPoints = grades.Sum(g => g.GradePoint);
        return totalPoints / grades.Count;
    }

    public void DisplayGradeInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}, Course ID: {CourseID}, Score: {Score}, Grade Point: {GradePoint}");
    }
}
