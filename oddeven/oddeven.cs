using System;

class Grade
{
    static void Main()
    {
        string str;
        Console.Write("Enter number1: ");
        str = Console.ReadLine();
        int n1 = int.Parse(str);

        if (n1 % 2 == 0)
        {
            Console.WriteLine($"{n1} is even");
        }
        else
        {
            Console.WriteLine($"{n1} is odd");
        }



    }
}
