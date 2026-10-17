using System;
static void PrintByColumns(double[,] matrix, int n, int m)
{
    Console.WriteLine("Вывод по столбцам");
    for (int j = 0; j < m; j++)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int n, m;
Console.Write("n = ");
while (!int.TryParse(Console.ReadLine(), out n) || n <=0)
{
    Console.WriteLine("введите целое число (без букв и пробелов)");
    Console.Write("n = ");
}

Console.Write("m = ");
while (!int.TryParse(Console.ReadLine(), out m) || m <=0)
{
    Console.WriteLine("введите целое число (без букв и пробелов)");
    Console.Write("m = ");
}

Console.WriteLine($"Вы ввели: n = {n}, m = {m}");

double[,] matrix = new double[n, m];
Console.WriteLine("Введите матрицу построчно:");
for (int i = 0; i < n; i++)
{
    bool isRowCorrect = false;
    while (!isRowCorrect)
    {
        Console.Write($"Строка {i + 1}: ");
        string[] row = Console.ReadLine().Split();

        if (row.Length != m)
        {
            Console.WriteLine($"Нужно ввести ровно {m} чисел, а вы ввели {row.Length}. Попробуйте снова.");
            continue;
        }
        isRowCorrect = true;
        for (int j = 0; j < m; j++)
        {
            if (!double.TryParse(row[j], out matrix[i, j]))
            {
                Console.WriteLine("Ошибка в вводе");
                isRowCorrect = false;
                break;
            }
        }
    }
}

Console.WriteLine("--- Исходная матрица ---");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write($"{matrix[i, j]} ");
    Console.WriteLine();
}

PrintByColumns(matrix, n, m);



