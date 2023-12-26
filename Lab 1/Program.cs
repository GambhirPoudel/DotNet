using System;

public class Student
{

    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }


    private static int totalStudents = 0;


    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
        totalStudents++;
    }


    ~Student()
    {
        totalStudents--;
        Console.WriteLine($"{Name} has been deleted.");
    }


    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }


    public static int GetTotalStudents()
    {
        return totalStudents;
    }
}

class Program
{
    static void Main()
    {

        Student student1 = new Student("John Doe", 20, "A");
        student1.DisplayInfo();


        Console.WriteLine($"Total Students: {Student.GetTotalStudents()}");


        Student student2 = new Student("Jane Smith", 22, "B");
        student2.DisplayInfo();


        Console.WriteLine($"Total Students: {Student.GetTotalStudents()}");



        Console.ReadLine();
    }
}