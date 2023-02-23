using System.ComponentModel.Design.Serialization;
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> по такому индексу нет элемента.

//? Сообщение

Console.Clear();
Console.Write($"Введите кол-во строк массива: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write($"Введите кол-во колон массива: ");
int n = int.Parse(Console.ReadLine()!);

//? Координаты массива 

Console.Write($"Введите координату (X) массива: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write($"Введите координату (Y) массива: ");
int y = int.Parse(Console.ReadLine()!);

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

void PrintArray(int[,] AArray)
{
    for (int i = 0; i < AArray.GetLength(0); i++)
    {
        for (int j = 0; j < AArray.GetLength(1); j++)
        {
            Console.Write($"{AArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintValue(int[,] AArray, int x, int y)
    {
        if (x < 0 || x >= AArray.GetLength(0) || y < 0 || y >= AArray.GetLength(1))
        {
            Console.WriteLine($"Элемент с такими позициями не существует");
        }
        else
        {
            Console.WriteLine($"Значение элемента: {AArray[x, y]}");
        }
    }

//? Вывод

int[,] array = FillArray(m, n, 0, 10);
PrintArray(array);
Console.WriteLine();
// PrintValue(AArray, x, y);




