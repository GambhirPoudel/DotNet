using System;

class Grade
{
    static void Main()
    {

        Console.Write("Enter marks: ");

       
        int subjectMark = Convert.ToInt32(Console.ReadLine());

        
        string grade;

        if (subjectMark >= 90)
        {
            grade = "A";
        }
        else if (subjectMark >= 80)
        {
            grade = "A-";
        }
        else if (subjectMark >= 70)
        {
            grade = "B";
        }
        else if (subjectMark >= 60)
        {
            grade = "B-";
        }
        else if (subjectMark >= 50)
        {
            grade = "C";
        }
        else
        {
            grade = "C-";
        }

        
        Console.WriteLine($"Equivalent Grade: {grade}");
    }
}
