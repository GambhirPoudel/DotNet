using System;

class Sum
{
    static int SumOfNaturalNumbers(int n)
    {
       
        if (n == 0)
            return 0;

        
        return n + SumOfNaturalNumbers(n - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter a positive integer (n):");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else
        {
            int sum = SumOfNaturalNumbers(n);
            Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
        }
    }
}
