namespace lab8;

public class Institution
{
    public List<Student> Students {get; set; }
    public int testValue = 4;

    public Institution()
    {
        Students = new List<Student>();
    }

    protected Institution(List<Student> students)
    {
        this.Students = students;
    }

    ~Institution()
    {
        Console.WriteLine("Institution destroyed");
    }

    // Start
    private void InstitutionInfo()
    {
        Console.WriteLine("This is private institution info");
    }

    protected void CallProtected()
    {
        Console.WriteLine("This is Protected institution info");
    }

    public virtual void ProcessWithStudents()
    {
        Console.WriteLine("Processing Institution");
        InstitutionInfo();
    }
    // END

    public virtual void Print()
    {
        Console.WriteLine("Current students: ");
        Console.WriteLine("==========");
        foreach (var student in Students)
        {
            student.Print();
            Console.WriteLine("==========");
        }
        Console.WriteLine();
    }
}