// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Pls enter rows number: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Pls enter columns number: ");
int columns = int.Parse(Console.ReadLine());

int minValue = -100;
int maxValue = 120;

int[,] array = FillArray(rows, columns, minValue, maxValue);
PrintArray(array);

Console.Write("Pls enter element's row position: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Pls enter element's column position: ");
int n = int.Parse(Console.ReadLine());

GetElementByPosition(array);

int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetElementByPosition(int[,] arr)
{
    if (m > array.GetLength(0) || n > array.GetLength(1))
    {
        Console.WriteLine($"[{m}, {n}] -> There is no such element's position in massive");
    }
    else
    {
        Console.WriteLine($"element with position [{m},{n}] is {array[m, n]}");
    }
}


