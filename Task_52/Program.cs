// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void GetAvergeColumn(int[,] massive)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < massive.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        avarage = (avarage + massive[i, j]);
    }
    avarage = (avarage / massive.GetLength(0));
    Console.Write(avarage + "; ");
}
Console.WriteLine();
}

void Print2DMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DArray(int rows, int columns, int startVaue, int finishvalue)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startVaue, finishvalue + 1);
        }
    }
    return matrix;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк: ");
int n = GetInput("Введите количество столбцов: ");
int[,] massive = Create2DArray(m, n, 0, 10);
Print2DMassive(massive);
GetAvergeColumn(massive);