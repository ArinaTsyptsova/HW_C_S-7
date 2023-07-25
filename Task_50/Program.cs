// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print2DMassive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Create2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите номер строки: ");
int n = GetInput("Введите номер столбца: ");
int[,] numbers = new int[10, 10];
Create2DArray(numbers);

if (m > numbers.GetLength(0) || n > numbers.GetLength(1)) Console.WriteLine("такого числа в массиве нет");
else
{
    Console.WriteLine($"значение элемента {m} строки {n} столбца равно {numbers[m - 1, n - 1]}");
    Print2DMassive(numbers);
}