// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Pls enter number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Pls enter number of columns: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = FillArray(rows, columns);
PrintArray(array);

double[,] FillArray(int m, int n)
{
    double[,] working = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            working[i, j] = new Random().NextDouble() * 10;
        }
    }
    return working;
}

void PrintArray(double[,] inarray)
{
    Console.WriteLine($"m = {rows}, n = {columns}.");
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            Console.Write($"{Math.Round((inarray[i, j]), 1)} ");
        }
        Console.WriteLine();
    }
}
