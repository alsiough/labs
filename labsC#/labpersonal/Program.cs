using System;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ParentName { get; set; }

    public Student(string firstName, string lastName, string parentName)
    {
        FirstName = firstName;
        LastName = lastName;
        ParentName = parentName;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}, father: {ParentName}";
    }
}

class StudentTable
{
    private Student[] students;

    public StudentTable(int size)
    {
        students = new Student[size];
    }

    public Student this[int index]
    {
        get
        {
            if (index < 0 || index >= students.Length)
            {
                throw new IndexOutOfRangeException("index is out of array.");
            }
            return students[index];
        }
        set
        {
            if (index < 0 || index >= students.Length)
            {
                throw new IndexOutOfRangeException("index is out of array.");
            }
            students[index] = value;
        }
    }

    public int Count
    {
        get { return students.Length; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        StudentTable studentTable = new StudentTable(3);

        
        studentTable[0] = new Student("Ivan", "Ivanov", "Oleksii Ivanovich");
        studentTable[1] = new Student("Anna", "Petrenko", "Mary Petrivna");
        studentTable[2] = new Student("Peter", "Sydorov", "Ivan Sydorovich");

        
        for (int i = 0; i < studentTable.Count; i++)
        {
            Console.WriteLine(studentTable[i]);
        }

        
        Console.WriteLine($"students amount: {studentTable.Count}");
    }
}