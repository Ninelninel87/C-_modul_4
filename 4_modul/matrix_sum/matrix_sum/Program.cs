using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите кол-во рядов: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите кол-во колонок: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix1 = new int[rows, columns];
        int[,] matrix2 = new int[rows, columns];
        int[,] sumMatrix = new int[rows, columns];
        Random random = new Random();

        Console.WriteLine("Первая матрица: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix1[i, j] = random.Next(1, 100);
                Console.Write(matrix1[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Вторая матрица: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix2[i, j] = random.Next(1, 100);
                Console.Write(matrix2[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Сумма матриц: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write(sumMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}