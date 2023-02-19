// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//? Сообщение

Console.Clear();
Console.Write($"Введите кол-во строк массива: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write($"Введите кол-во колон массива: ");
int n = int.Parse(Console.ReadLine()!);

//? Методы

int[,] FillArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] EArray)
{
    for (int i = 0; i < EArray.GetLength(0); i++)
    {
        for (int j = 0; j < EArray.GetLength(1); j++)
        {
            Console.Write($"{EArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

//? Вывод

int[,] array = FillArray(m, n, -9, 9);
PrintArray(array);