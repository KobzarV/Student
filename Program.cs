using Student;

class Program
{
    static void Main()
    {
        int[] homeworks = new[] { 66, 77, 87, 100, 50, 66, 78 };
        int[] finWorks = new[] { 78, 75, 82, 100, 95, 65 };
        int[] exams = new[] { 90, 71, 87, 100 };
        Student.Student student1 = new Student.Student("Smith", "John", "Joich", new DateTime(2006, 3, 15), new Address("123 Main St", "London", "UK"), "123-456-7890", homeworks, finWorks, exams);
        Student.Student student2 = new Student.Student("Anderson", "Tom", "Markovich", new DateTime(1990, 12, 21), new Address("12 Vilcov St", "Odesa", "UKR"), "321-426-7890", new int[] { 100,90,88,75}, new int[] { 72, 90 }, new int[] { 100, 90 });
        Student.Student student3 = new Student.Student("Paterson", "Mark", "Leonovich");
        Student.Student student4 = new Student.Student("Alvares", "Juan", new int[] { 98,77,65,89,90,66}, new int[] { 59,61,99,88}, new int[] { 90,76,88});
        
        student2.AddHomeworkGrade(95);
        student2.AddFinalPaperGrade(88);
        student2.AddExamGrade(75);

        student3.AddHomeworkGrade(77);
        student3.AddHomeworkGrade(95);
        student3.AddHomeworkGrade(83);
        student3.AddFinalPaperGrade(69);
        student3.AddFinalPaperGrade(74);
        student3.AddExamGrade(90);
        student3.AddExamGrade(78);
        student3.PhoneNumber = "432-567-8788";

        student4.HomeAddress = new Address("luice St","Mexico-City","Mexica");

        student1.ShowStudentInfo();
        student2.ShowStudentInfo();
        student3.ShowStudentInfo();
        student4.ShowStudentInfo();
    }
}