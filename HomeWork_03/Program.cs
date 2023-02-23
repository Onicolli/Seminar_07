// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void AverageArray(int[,] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j++)
    {
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i, j];
        }

        double average = (double)sum /array.Length;

        Console.WriteLine($"Среднее арефмитическое {j + 1} -> {average}");
    }
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

int[,] array = FillArray(m, n, 0, 9);
PrintArray(array);
AverageArray(array);