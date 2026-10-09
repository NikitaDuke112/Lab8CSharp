namespace lab8;

public sealed class Group
{
    public List<Student> Students {get; set;}
    public string Name { get; set; }
    public string Faculty {get; set;}
    public short Year { get; set; }

    public Group()
    {
        Students = new List<Student>();
        Name = "";
        Faculty = "";
        Year = 0;
    }

    public Group(string name, string faculty, short year)
    {
        Students = new List<Student>();
        Name = name;
        Faculty = faculty;
        Year = year;
    }

    ~Group()
    {
        Console.WriteLine("Group destroyed");
    }

    public List<Student> CopyStudents()
    {
        List<Student> copyStudents = new List<Student>(Students);
        return copyStudents;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Faculty: {Faculty}");
        Console.WriteLine($"Year: {Year}");
        
        Console.WriteLine("Students:");
        Console.WriteLine("==========");
        foreach (Student student in Students)
        {
            student.Print();
            Console.WriteLine("==========");
        }
        Console.WriteLine();
    }
}