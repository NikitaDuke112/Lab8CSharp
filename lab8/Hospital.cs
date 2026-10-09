namespace lab8;

internal class Hospital : Institution
{
    public string Name { get; set; }
    public string Address { get; set; }
    public new int testValue = 2;

    public Hospital()
    {
        Name = "";
        Address = "";
    }

    public Hospital(string name, string address, List<Student> students) : base(students)
    {
        Name = name;
        Address = address;
    }

    ~Hospital()
    {
        Console.WriteLine("Hospital destroyed");
    }

    public override void ProcessWithStudents()
    {
        Console.WriteLine("==========");
        foreach (Student student in Students)
        {
            Console.WriteLine($"Student {student.Fullname}: ");
            foreach (KeyValuePair<string, int> medical in student.MedicalRecord)
            {
                if (medical.Value >= 7)
                {
                    Console.WriteLine($"Medical {medical.Key}: {medical.Value} is Good");
                }
                else if (medical.Value >= 3)
                {
                    Console.WriteLine($"Medical {medical.Key}: {medical.Value} is Bad");
                }
                else
                {
                    Console.WriteLine($"Medical {medical.Key}: {medical.Value} is awful");
                }
            }
            Console.WriteLine("==========");
        }
    }

    public override void Print()
    {
        Console.WriteLine($"Hospital: {Name}");
        Console.WriteLine($"Address: {Address}");
        base.Print();
    }

    public void TestFunction()
    {
        Students = new List<Student>();
        Console.WriteLine($"Hospital: {testValue}");
        Console.WriteLine($"Hospital: {base.testValue}");
    }
}