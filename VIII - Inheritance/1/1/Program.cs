public class Person
{
    public string Name { get; private set; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Person: {Name}";
    }
}
public class Student : Person
{
    public Student(string name) : base(name) { }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }
}

public class Teacher : Person
{
    public Teacher(string name) : base(name) { }

    public void Explain()
    {
        Console.WriteLine($"{Name} is explaining.");
    }
}
class Program
{
    static void Main()
    {
        Person[] people = new Person[3];

        Console.WriteLine("Enter the name of the first student:");
        people[0] = new Student(Console.ReadLine());

        Console.WriteLine("Enter the name of the second student:");
        people[1] = new Student(Console.ReadLine());

        Console.WriteLine("Enter the name of the teacher:");
        people[2] = new Teacher(Console.ReadLine());

        foreach (var person in people)
        {
            Console.WriteLine(person);

            if (person is Student student)
            {
                student.Study();
            }
            else if (person is Teacher teacher)
            {
                teacher.Explain();
            }
        }
    }
}
