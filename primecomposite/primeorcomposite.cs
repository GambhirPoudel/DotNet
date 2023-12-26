using System;

class primeorcomposite
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a prime number.");
        }
        else if (IsPrime(number))
        {
            Console.WriteLine($"{number} is a composite number.");
        }
        else 
        {
            Console.WriteLine($"{number} is neither prime nor composite");
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
