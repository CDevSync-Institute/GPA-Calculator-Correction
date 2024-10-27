using GPA_Calculator.Methods;
using GPA_Calculator.Model;

class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Gpa Calcualatiuon Class for CDevSyncInstitute Squad 1");
        Console.WriteLine("Please press enter to continue");
        Console.ReadKey();
        GPA gPA = new GPA();
        Console.WriteLine("Please supply matric No");
        gPA.matricNo = Console.ReadLine();
        Console.WriteLine("Please supply number of courses");
        gPA.totalCourse=int.Parse(Console.ReadLine());
        Console.WriteLine("Please You will be supply Course details now");
        List<Course> courses = new List<Course>();
        GradeSaga gradeSaga = new GradeSaga();
        gPA.totalGradeReceived = 0;
        gPA.totalGradePoint= 0;
        for (int i = 0; i < gPA.totalCourse; i++)
        {
            Course course = new Course();
            Console.WriteLine($"please supply courseName of course {i+1}");
                course.courseName= Console.ReadLine();
            Console.WriteLine($"please supply course code of course {i+1}");
                course.courseCode= Console.ReadLine();
            Console.WriteLine($"please supply course unit of course {i+1}");
            course.courseUnit= int.Parse(Console.ReadLine());
            gPA.totalGradePoint = gradeSaga.ComputeTotalGrade(gPA.totalGradePoint, course.courseUnit);
            Console.WriteLine($"please supply course Description of course {i+1}");
            course.courseDescription = Console.ReadLine();
            courses.Add(course);
            gPA.courses.Add(course);
        }
        Console.WriteLine("Please You will be supply Grade details now");
        List<Grade> grades = new List<Grade>();
        int counter= 1;
        foreach (Course course in courses)
        {
            Grade grade = new Grade();
            Console.WriteLine($"please supply score for {course.courseName}({course.courseCode})");
            grade.scoreReceived = int.Parse(Console.ReadLine());
            grade.id = counter;
            grade.courseCode = course.courseCode;
            grade.gradeCharacter = gradeSaga.GetGradeCharacter(grade.scoreReceived);
            grade.gradePoint = gradeSaga.GetGradePoint(grade.gradeCharacter);
            gPA.totalGradeReceived = GradeSaga.CalculateTotalGradeReceived(gPA.totalGradeReceived, grade.gradePoint);
            counter++;
            grades.Add(grade);
            gPA.grades.Add(grade);
        }
        gPA.finalGPA = GPASaga.CalculateFinalGPA(gPA.totalGradeReceived, gPA.totalGradePoint);
        Console.WriteLine("Course Code || Course Name || Course Unit ||Course Descr || Score Received || Grade Received || Grade Point Received ");
        foreach (Course course in courses)
        {
            Grade grade = grades.FirstOrDefault(u => u.courseCode == course.courseCode);
            Console.WriteLine($"{course.courseCode} || {course.courseName} || {course.courseUnit} ||{course.courseDescription}|| {grade.scoreReceived} || {grade.gradeCharacter} || {grade.gradePoint} ");
        }
        Console.WriteLine($"Final GPA={gPA.totalGradePoint}/{gPA.totalGradeReceived} for {gPA.totalCourse} courses ={gPA.finalGPA}");
    }
}