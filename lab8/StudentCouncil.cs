namespace lab8;

internal class StudentCouncil : Institution
{
    public string Leader {get; set;}
    
    public StudentCouncil()
    {   
        Leader = "";
    }
    
    public StudentCouncil(string leader, List<Student> students) : base(students)
    {
        Leader = leader;
    }

    ~StudentCouncil()
    {
        Console.WriteLine("Student council destroyed");
    }

    public override void ProcessWithStudents()
    {
        Console.WriteLine("==========");
        foreach (Student student in Students)
        {
            switch (student.Gender)
            {
                case 'M':
                    if (student.Activities.Count >= 4)
                    {
                        Console.WriteLine($"Student {student.Fullname} is very active");
                    }
                    else if (student.Activities.Count >= 2)
                    {
                        Console.WriteLine($"Student {student.Fullname} is active");
                    }
                    else
                    {
                        Console.WriteLine($"Student {student.Fullname} is watcher");
                    }
                    break;
                case 'F':
                    if (student.Activities.Count >= 3)
                    {
                        Console.WriteLine($"Student {student.Fullname} is very active");
                    }
                    else if (student.Activities.Count >= 1)
                    {
                        Console.WriteLine($"Student {student.Fullname} is active");
                    }
                    else
                    {
                        Console.WriteLine($"Student {student.Fullname} is watcher");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown gender");
                    break;
            }
        }
    }

    public override void Print()
    {
        Console.WriteLine($"Leader: {Leader}:");
        base.Print();
    }
}