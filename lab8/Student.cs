namespace lab8;

public class Student
{
    public string Fullname { get; set; }
    public short Age { get; set; }
    public char Gender { get; set; }
    public bool HasScholarship { get; set; }
    public Dictionary<string, List<int>> AcademicPerformance { get; set; }
    public Dictionary<string, int> MedicalRecord { get; set; }
    public List<string> Activities { get; set; }
    public string Id { get; }

    public Student(string id)
    {
        Fullname = "";
        Age = 0;
        Gender = 'M';
        HasScholarship = false;
        AcademicPerformance = new Dictionary<string, List<int>>();
        MedicalRecord = new Dictionary<string, int>();
        Activities = new List<string>();
        Id = id;
    }
    
    public Student(string fullname, short age,  char gender, bool hasScholarship, string id)
    {
        Fullname = fullname;
        Age = age;
        Gender = gender;
        HasScholarship = hasScholarship;
        AcademicPerformance = new Dictionary<string, List<int>>();
        MedicalRecord = new Dictionary<string, int>();
        Activities = new List<string>();
        Id = id;
    }
    
    public Student(string fullname, short age,  char gender, bool hasScholarship, 
        Dictionary<string, List<int>> academicPerformance, Dictionary<string, int> medicalRecord, 
        List<string> activities, string id)
    {
        Fullname = fullname;
        Age = age;
        Gender = gender;
        HasScholarship = hasScholarship;
        AcademicPerformance = academicPerformance;
        MedicalRecord = medicalRecord;
        Activities = activities;
        Id = id;
    }

    public Student(Student other)
    {
        Fullname = other.Fullname;
        Age = other.Age;
        Gender = other.Gender;
        HasScholarship = other.HasScholarship;
        AcademicPerformance = other.AcademicPerformance;
        MedicalRecord = other.MedicalRecord;
        Activities = other.Activities;
        Id = other.Id;
    }

    ~Student()
    {
        Console.WriteLine("Student destroyed");
    }

    public void Print()
    {
        Console.WriteLine($"Fullname: {Fullname}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"HasScholarship: {HasScholarship}");

        Console.WriteLine($"AcademicPerformance ({AcademicPerformance.Count} count): ");
        if (AcademicPerformance.Count == 0)
        {
            Console.WriteLine("None");
        }
        foreach (KeyValuePair<string, List<int>> academicPerformance in AcademicPerformance)
        {
            Console.Write($"\t{academicPerformance.Key}: ");
            foreach (int mark in academicPerformance.Value)
            {
                Console.Write($"{mark} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"MedicalRecord ({MedicalRecord.Count} count): ");
        if (MedicalRecord.Count == 0)
        {
            Console.WriteLine("None");
        }
        foreach (KeyValuePair<string, int> medicalRecord in MedicalRecord)
        {
            Console.WriteLine($"\t{medicalRecord.Key}: {medicalRecord.Value}");
        }

        Console.Write("Activities: ");
        if (Activities.Count == 0)
        {
            Console.Write("None");
        }
        for (int i = 0; i < Activities.Count; i++)
        {
            if (i == Activities.Count - 1)
            {
                Console.Write(Activities[i] + ".");
            }
            else
            {
                Console.Write(Activities[i] + ", ");
            }
        }
        Console.WriteLine();
        
        Console.WriteLine($"Student ID: {Id}");
    }
}