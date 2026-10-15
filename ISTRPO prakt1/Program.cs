using System;
static void PrintByColumns(double[,] matrix, int n, int m)
{
    Console.WriteLine("Вывод по столбцам");
    for (int j = 0; j < m; j++)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());


double[,] matrix = new double[n, m];
Console.WriteLine("Введите матрицу построчно:");
for (int i = 0; i < n; i++)
{
    string[] row = Console.ReadLine().Split();
    for (int j = 0; j < m; j++)
        matrix[i, j] = double.Parse(row[j]);
}

Console.WriteLine("--- Исходная матрица ---");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + "\t");
    Console.WriteLine();
}

PrintByColumns(matrix, n, m);



