using System;

class fibo
{
    static void Main()
    {
        Console.Write("Enter the number of terms ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibo(i) + " ");
        }
    }

    static int Fibo(int n)
    {
        if (n <= 1)
        {
            return n;  
        }
        else
        {
            int first = 0, second = 1, result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            return result;
        }
    }
}
