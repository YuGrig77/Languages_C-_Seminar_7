// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д. 

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

Console.WriteLine();

int MatrixSum(int[,] intArray)
{
    int m = intArray.GetLength(0);
    int n = intArray.GetLength(1);
    int len = 0;
    int sum = 0;
    if (m > n) len = n;
    else len = m;

    for (int i = 0; i < len; i++)
    {
        sum = sum + intArray[i, i];
    }
    return sum;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
