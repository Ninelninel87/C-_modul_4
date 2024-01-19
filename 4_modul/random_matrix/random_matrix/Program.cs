using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество рядов: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество колонок: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        Random random = new Random();

        Console.WriteLine("Матрица: ");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 100); 
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                sum += matrix[i, j];
            }
        }

        Console.WriteLine("Сумма всех элементов: " + sum);
    }
}

