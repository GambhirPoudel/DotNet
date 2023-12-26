using System;

class fact
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(number);

        Console.WriteLine($"Factorial of {number} is {factorial}");
    }

    static long CalculateFactorial(int num)
    {
        

        if (num == 0 || num == 1)
        {
            return 1;
        }

        int result = 1;
        for (int i = 2; i <= num; i++)
        {
            result = result * i;
        }

        return result;
    }
}
