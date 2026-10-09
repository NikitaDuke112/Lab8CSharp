namespace lab8
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Nikita Klochkov", 19, 'M', true, "1");
            Student student2 = new Student("Alex Smirov", 18, 'M', false, "2");
            Student student3 = new Student("Dmitry Lebev", 20, 'M', false, "3");
            Student student4 = new Student("Maxim Ivanov", 21, 'M', true, "4");
            Student student5 = new Student("Maria Krav", 19, 'F', true, "5");
            
            student1.AcademicPerformance.Add("Mathematics", new List<int>() {4, 4, 5, 5, 5});
            student1.AcademicPerformance.Add("English", new List<int>() {4, 4, 3, 5, 5});
            student1.AcademicPerformance.Add("OOP", new List<int>() {5, 5, 5, 5, 5});
            student1.MedicalRecord.Add("Eyesight", 5);
            student1.MedicalRecord.Add("Hearing", 10);
            student1.Activities.Add("faculty sport");
            student1.Activities.Add("theater");
            student1.Activities.Add("volunteering");
            student1.Activities.Add("olympiad");
            student1.Activities.Add("debut");
            
            student2.AcademicPerformance.Add("Mathematics", new List<int>() {2, 3, 4, 4, 4});
            student2.AcademicPerformance.Add("English", new List<int>() {4, 5, 5, 5, 5});
            student2.AcademicPerformance.Add("OOP", new List<int>() {5, 2, 3, 3, 3});
            student2.MedicalRecord.Add("Eyesight", 8);
            student2.MedicalRecord.Add("Hearing", 8);
            student2.Activities.Add("faculty sport");
            student2.Activities.Add("volunteering");
            student2.Activities.Add("debut");
            
            student3.AcademicPerformance.Add("Mathematics", new List<int>() {4, 2, 5, 5, 4});
            student3.AcademicPerformance.Add("English", new List<int>() {4, 4, 3, 4, 4});
            student3.AcademicPerformance.Add("OOP", new List<int>() {1, 1, 3, 3, 4});
            student3.MedicalRecord.Add("Eyesight", 10);
            student3.MedicalRecord.Add("Hearing", 4);
            student3.Activities.Add("olympiad");
            student3.Activities.Add("debut");
            
            student4.AcademicPerformance.Add("Mathematics", new List<int>() {5, 5, 5, 5, 5});
            student4.AcademicPerformance.Add("English", new List<int>() {4, 4, 3, 3, 4});
            student4.AcademicPerformance.Add("OOP", new List<int>() {5, 5, 5, 5, 4});
            student4.MedicalRecord.Add("Eyesight", 2);
            student4.MedicalRecord.Add("Hearing", 7);
            student4.Activities.Add("faculty sport");
            student4.Activities.Add("theater");
            
            student5.AcademicPerformance.Add("Mathematics", new List<int>() {3, 5, 4, 5, 4});
            student5.AcademicPerformance.Add("English", new List<int>() {5, 4, 4, 4, 4});
            student5.AcademicPerformance.Add("OOP", new List<int>() {5, 4, 3, 3, 3});
            student5.MedicalRecord.Add("Eyesight", 6);
            student5.MedicalRecord.Add("Hearing", 1);
            
            Group group1 = new Group("CS22B", "FCIT", 2);
            group1.Students.Add(student1);
            group1.Students.Add(student2);
            group1.Students.Add(student3);
            
            Group group2 = new Group("CS21B", "FCIT", 2);
            group2.Students.Add(student4);
            group2.Students.Add(student5);
            
            group1.Print();
            group2.Print();
            
            Console.WriteLine("========== INSTITUTIONS ==========");
            Console.WriteLine("========== HOSPITAL ==========");
            
            Hospital hospital = new Hospital("Hmn Hospital", "Evergreen Terrace, Springfield, OR 97477", 
                group1.CopyStudents());
            
            hospital.Print();
            hospital.ProcessWithStudents();
            Console.WriteLine();
            
            hospital.Students = group2.CopyStudents();
            
            hospital.Print();
            hospital.ProcessWithStudents();
            Console.WriteLine();
            
            Console.WriteLine("========== DEANS_OFFICE ==========");
            DeansOffice deansOffice = new DeansOffice("Oleg Dikiy", 604, group1.CopyStudents());
            
            deansOffice.Print();
            deansOffice.ProcessWithStudents();
            Console.WriteLine();
            
            deansOffice.Students = group2.CopyStudents();
            
            deansOffice.Print();
            deansOffice.ProcessWithStudents();
            
            Console.WriteLine("========== STUDENT_COUNCIL ===========");
            StudentCouncil studentCouncil = new StudentCouncil("Lesia", group1.CopyStudents());
            studentCouncil.Print();
            studentCouncil.ProcessWithStudents();
            Console.WriteLine();
            
            studentCouncil.Students = group2.CopyStudents();
            
            studentCouncil.Print();
            studentCouncil.ProcessWithStudents();
            Console.WriteLine();
            
            Institution institution = new Institution();
            institution.ProcessWithStudents();
        }
    }
}