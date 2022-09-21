// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();

Console.Write("Pls enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Pls enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

int minValue = 0;
int maxValue = 10;

int[,] array = FillArray(rows, columns, minValue, maxValue);
PrintArray(array);

GetColumnMidArithmetical(array);

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] working = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            working[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return working;
}

void PrintArray(int[,] inarray)
{
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write($"{inarray[i, j]}    ");
        }
        Console.WriteLine();
    }
}

void GetColumnMidArithmetical(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        sum /= rows;
        Console.Write(j != arr.GetLength(1) - 1 ? $"{Math.Round(sum, 1)}; " : $"{Math.Round(sum, 1)}");
    }
    Console.Write(" -> columns mid arithmetical");
}