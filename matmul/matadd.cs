using System;

class matadd
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[][] matrixA = new int[rows][];
        int[][] matrixB = new int[rows][];
        int[][] resultMatrix = new int[rows][];

        Console.WriteLine("Enter elements of matrix A:");
        ReadMatrix(matrixA, rows, cols);

        Console.WriteLine("Enter elements of matrix B:");
        ReadMatrix(matrixB, rows, cols);

        Console.WriteLine("Matrix A:");
        PrintMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        PrintMatrix(matrixB);

        resultMatrix = Add(matrixA, matrixB);

        Console.WriteLine("Resultant Matrix:");
        PrintMatrix(resultMatrix);
    }

    static void ReadMatrix(int[][] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new int[cols];
            string[] elements = Console.ReadLine().Split(' ');
            for (int j = 0; j < cols; j++)
            {
                matrix[i][j] = int.Parse(elements[j]);
            }
        }
    }

    static int[][] Add(int[][] matrixA, int[][] matrixB)
    {
        int rows = matrixA.Length;
        int cols = matrixA[0].Length;
        int[][] resultMatrix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            resultMatrix[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i][j] = matrixA[i][j] + matrixB[i][j];
            }
        }

        return resultMatrix;
    }

    static void PrintMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
