using System;

class BubbleSort
{
    static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 5, 6 };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        BubbleSortArray(arr);

        Console.WriteLine("\nSorted array in ascending order:");
        PrintArray(arr);
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
