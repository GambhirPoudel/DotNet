using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    private static int totalPersons;

    static Person()
    {
        Console.WriteLine("Static constructor called.");
        totalPersons = 0;
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        totalPersons++;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    public static void DisplayTotalPersons()
    {
        Console.WriteLine($"Total persons created: {totalPersons}");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person { Name = "John", Age = 25 };
        Person person2 = new Person { Name = "Alice", Age = 30 };

        Console.WriteLine("Information about person1:");
        person1.DisplayInfo();

        Console.WriteLine("\nInformation about person2:");
        person2.DisplayInfo();

        Person.DisplayTotalPersons();
    }
}
