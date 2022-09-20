// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, и 
// замените эти элементы на их квадраты.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 2, 12);
PrintArray(array);
Console.WriteLine();
GetPow(array);
PrintArray(array);

//int arr = array.Length; - покажет сколько всего элементов в массиве
//Console.WriteLine(arr);

int[,] GetArray(int m, int n, int minValue, int maxValue)
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
void GetPow(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            inArray[i, j] = inArray[i, j] * inArray[i, j];
        }
    }
}



//or

// Console.Clear();
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 9);
// PrintArray(array);

// Console.WriteLine();
// int[,] processedArray = ProcessArray(array);
// PrintArray(processedArray);

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }
// int[,] ProcessArray(int[,] intArray)
// {
//     int m = intArray.GetLength(0);
//     int n = intArray.GetLength(1);

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             if (i%2==0 && j%2==0)
//             {
//                 intArray[i, j] = intArray[i, j]*intArray[i, j];
//             }
//         }
//     }
//     return intArray;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
