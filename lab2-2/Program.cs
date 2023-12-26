using System;

public class Person
{
   
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    
    private static int instanceCount = 0;

    
    static Person()
    {
        Console.WriteLine("Static constructor called.");
    }

    
    public Person(string firstName, string lastName, int age)
    {
       
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;

        
        instanceCount++;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
    }

    
    public static int GetInstanceCount()
    {
        return instanceCount;
    }
}

class Program
{
    static void Main()
    {
        
        Person person1 = new Person { FirstName = "John", LastName = "Doe", Age = 30 };
        person1.DisplayInfo();

        
        Person person2 = new Person("Jane", "Smith", 25);
        person2.DisplayInfo();

        
        Console.WriteLine($"Total instances created: {Person.GetInstanceCount()}");

        Console.ReadLine();
    }
}
