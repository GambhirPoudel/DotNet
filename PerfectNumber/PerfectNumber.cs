using System;

class perfectnumber
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPerfectNumber(number))
        {
            Console.WriteLine($"{number} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number.");
        }
    }

    static bool IsPerfectNumber(int num) //bool le boolen return garxa 
    {
        if (num <= 0) // perfect num -ve hudaina 
        {
            return false; 
        }

        int sumOfDivisors = 0;

        for (int divisor = 1; divisor <= num / 2; divisor++)
        {
            if (num % divisor == 0)
            {
                sumOfDivisors += divisor; //subdiv=subdiv+div
            }
        }

        return sumOfDivisors == num;
    }
}
