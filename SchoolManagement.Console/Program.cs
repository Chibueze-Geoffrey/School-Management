using SchoolManagement;
// Create school
var school = new School();

Console.WriteLine("Welcome to School Management System");

while (true)
{
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Add Teacher");
    Console.WriteLine("3. Add Course");
    Console.WriteLine("4. Enroll Student in Course");
    Console.WriteLine("5. Assign Course to Teacher");
    Console.WriteLine("6. Display All Information");
    Console.WriteLine("7. Exit");

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
            DisplayMenu(school);
            break;
        case 7:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please choose again.");
            break;
    }

    Console.WriteLine();



    static void DisplayMenu(School school)
    {
        while (true)
        {
            DisplayAllInformation(school);
            Console.WriteLine();
            Console.WriteLine("1. Go Back");
            Console.WriteLine("2. Refresh Display");
            Console.WriteLine("3. Exit");
            here:
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
                    goto here;
            }
        }
    }

    static void DisplayAllInformation(School school)
    {
        ConsoleHelper.DisplayHeader("School Information");
        school.DisplaySchoolInfo();
        Console.WriteLine();

        ConsoleHelper.DisplayHeader("Student Information");
        ConsoleHelper.DisplayStudentInfo(school.Students);
        Console.WriteLine();

        ConsoleHelper.DisplayHeader("Teacher Information");
        ConsoleHelper.DisplayTeacherInfo(school.Teachers);
        Console.WriteLine();

        ConsoleHelper.DisplayHeader("Course Information");
        ConsoleHelper.DisplayCourseInfo(school.Courses);
        Console.WriteLine();

        ConsoleHelper.DisplayHeader("Student Course Enrollment");
        DisplayStudentCourseEnrollment(school);
        Console.WriteLine();

        ConsoleHelper.DisplayHeader("Teacher Course Assignment");
        DisplayTeacherCourseAssignment(school);
    }

    static void DisplayStudentCourseEnrollment(School school)
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

    static void DisplayTeacherCourseAssignment(School school)
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
}



static void AddStudent(School school)
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

    static void AddTeacher(School school)
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

    static void AddCourse(School school)
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

    static void EnrollStudentInCourse(School school)
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

    static void AssignCourseToTeacher(School school)
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


