using System;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int ID { get; set; }
    public string Address { get; set; }
}

class Search_Address
{
    static void Main()
    {
        Student[] s = new Student[]
        {
            new Student { Name = "Raj Lama", Age = 20, ID = 1, Address="Hetauda"},
            new Student { Name = "Shuvam Yadhav", Age = 21, ID = 2, Address="Pokhara" },
            new Student { Name = "Kapil Sapkota", Age = 22, ID = 3, Address="Butwal" },
            new Student { Name = "Sujal Bohora", Age = 19, ID = 4, Address="Dhangadhi" },
            new Student { Name = "Bikal Rumba", Age = 20, ID = 5, Address="Palung" }
        };

        Console.WriteLine("\n Enter the Address of Student");
        string AddressName = Console.ReadLine();

        Student foundStudent = SearchStudentByAddress(s, AddressName);

        if (foundStudent != null)
        {
            Console.WriteLine($"\nStudent found with address {AddressName}:");
            Console.WriteLine($"Name: {foundStudent.Name}, Age: {foundStudent.Age}, ID: {foundStudent.ID}, Address: {foundStudent.Address}");
        }
        else
        {
            Console.WriteLine($"\nNo Data Found with Address {AddressName}");
            Console.WriteLine("\nSearch using other Address");
        }
    }
    static Student SearchStudentByAddress(Student[] students, string AddressName)
    {
        foreach (Student student in students)
        {
            if (student.Address.Equals(AddressName, StringComparison.OrdinalIgnoreCase))
            {
                return student;
            }
        }
        return null;
    }
}
