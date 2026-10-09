namespace lab8;

internal class DeansOffice : Institution
{
    public string Fullname { get; set; }
    public int Cabinet {get; set;}
    
    public DeansOffice()
    {
        Fullname = "";
        Cabinet = 0;
    }

    public DeansOffice(string fullname, int cabinet, List<Student> students) : base(students)
    {
        Fullname = fullname;
        Cabinet = cabinet;
    }

    ~DeansOffice()
    {
        Console.WriteLine("Deans office destroyed");
    }
    
    public override void ProcessWithStudents()
    {
        Console.WriteLine("==========");
        foreach (Student student in Students)
        {
            Console.WriteLine($"Student {student.Fullname}: ");
            foreach (KeyValuePair<string, List<int>> academicPerformance in student.AcademicPerformance)
            {
                double average = 0;
                
                for (int i = 0; i < academicPerformance.Value.Count; i++)
                {
                    average += academicPerformance.Value[i];
                }
                average /= academicPerformance.Value.Count;
                
                average = Math.Round(average);

                if (average >= 5)
                {
                    Console.WriteLine($"{academicPerformance.Key} average: {average} is excellent");
                }
                else if (average >= 4)
                {
                    Console.WriteLine($"{academicPerformance.Key} average: {average} is good");
                }
                else if (average >= 3)
                {
                    Console.WriteLine($"{academicPerformance.Key} average: {average} is default");
                }
                else
                {
                    Console.WriteLine($"{academicPerformance.Key} average: {average} is bad");
                }
            }
            Console.WriteLine("==========");
        }
    }

    public override void Print()
    {
        Console.WriteLine($"Dean fullname: {Fullname}");
        Console.WriteLine($"Cabinet: {Cabinet}");
        base.Print();
    }
}