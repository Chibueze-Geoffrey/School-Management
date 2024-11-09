using SchoolManagement;

var school = new School();

Console.WriteLine("Welcome to School Management System");

while (true)
{
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Teacher");
    Console.WriteLine("3. Add Course");
    Console.WriteLine("4. Enroll Student in Course");
    Console.WriteLine("5. Assign Course to Teacher");
    Console.WriteLine("6. Add Grade for Student");
    Console.WriteLine("7. Display All Information");
    Console.WriteLine("8. Exit");

    Console.Write("Choose an option: ");
    int option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            AddStudent(school);
            break;
        case 2:
            AddTeacher(school);
            break;
        case 3:
            AddCourse(school);
            break;
        case 4:
            EnrollStudentInCourse(school);
            break;
        case 5:
            AssignCourseToTeacher(school);
            break;
        case 6:
            AddGradeForStudent(school);
            break;
        case 7:
            DisplayMenu(school);
            break;
        case 8:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please choose again.");
            break;
    }

    Console.WriteLine();
}

void DisplayMenu(School school)
{
    while (true)
    {
        ConsoleHelper.DisplayAllInformation(school);
        Console.WriteLine();
        Console.WriteLine("1. Go Back");
        Console.WriteLine("2. Refresh Display");
        Console.WriteLine("3. Exit");
        
        Console.Write("Choose an option: ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                return;
            case 2:
                continue;
            case 3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid option. Please choose again.");
                break;
        }
    }
}

void AddStudent(School school)
{
    Console.Write("Enter student name: ");
    string name = Console.ReadLine();
    Console.Write("Enter student age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter student grade level: ");
    int gradeLevel = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter student ID: ");
    string studentID = Console.ReadLine();

    var student = new Student(name, age, gradeLevel, studentID);
    school.AddStudent(student);
    Console.WriteLine("Student added successfully.");
}

void AddTeacher(School school)
{
    Console.Write("Enter teacher name: ");
    string name = Console.ReadLine();
    Console.Write("Enter teacher age: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter teacher department: ");
    string department = Console.ReadLine();
    Console.Write("Enter teacher ID: ");
    string teacherID = Console.ReadLine();

    var teacher = new Teacher(name, age, department, teacherID);
    school.AddTeacher(teacher);
    Console.WriteLine("Teacher added successfully.");
}

void AddCourse(School school)
{
    Console.Write("Enter course name: ");
    string courseName = Console.ReadLine();
    Console.Write("Enter course ID: ");
    string courseID = Console.ReadLine();
    Console.Write("Enter course credits: ");
    int credits = Convert.ToInt32(Console.ReadLine());

    var course = new Course(courseName, courseID, credits);
    school.AddCourse(course);
    Console.WriteLine("Course added successfully.");
}

void EnrollStudentInCourse(School school)
{
    Console.Write("Enter student ID: ");
    string studentID = Console.ReadLine();
    Console.Write("Enter course ID: ");
    string courseID = Console.ReadLine();

    var student = school.Students.Find(s => s.StudentID == studentID);
    var course = school.Courses.Find(c => c.CourseID == courseID);

    if (student != null && course != null)
    {
        student.EnrollCourse(course);
        Console.WriteLine("Student enrolled successfully.");
    }
    else
    {
        Console.WriteLine("Student or course not found.");
    }
}

void AssignCourseToTeacher(School school)
{
    Console.Write("Enter teacher ID: ");
    string teacherID = Console.ReadLine();
    Console.Write("Enter course ID: ");
    string courseID = Console.ReadLine();

    var teacher = school.Teachers.Find(t => t.TeacherID == teacherID);
    var course = school.Courses.Find(c => c.CourseID == courseID);

    if (teacher != null && course != null)
    {
        teacher.AssignCourse(course);
        Console.WriteLine("Course assigned successfully.");
    }
    else
    {
        Console.WriteLine("Teacher or course not found.");
    }
}

void AddGradeForStudent(School school)
{
    Console.Write("Enter student ID: ");
    string studentID = Console.ReadLine();
    Console.Write("Enter course ID: ");
    string courseID = Console.ReadLine();
    Console.Write("Enter score (0-100): ");

    // Read the score as a double
    if (double.TryParse(Console.ReadLine(), out double score))
    {
        var student = school.Students.Find(s => s.StudentID == studentID);
        var course = school.Courses.Find(c => c.CourseID == courseID);

        if (student != null && course != null)
        {
            var grade = new Grade(studentID, courseID, score); 
            student.AddGrade(grade);
            Console.WriteLine("Grade added successfully.");
        }
        else
        {
            Console.WriteLine("Student or course not found.");
        }
    }
    else
    {
        Console.WriteLine("Invalid score. Please enter a number between 0 and 100.");
    }
}

