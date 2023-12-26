using System;

class Avg
{
    static double CalculateAverage(int[] numbers)
    {
        if (numbers.Length == 0)
        {

            return 0.0;
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements (N):");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 1)
        {
            Console.Write("Please enter a valid positive integer for N.");
            return;
        }

        int[] numbers = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write($"Enter number {i + 1}:");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        double average = CalculateAverage(numbers);

        Console.WriteLine($"The average of the {N} numbers is: {average}");
    }
}
