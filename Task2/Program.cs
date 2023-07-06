// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 0, 0 -> 1
using System.Linq.Expressions;
using System.Xml.XPath;

Console.Clear();
int[,] GenerateArray2D(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int ReadConsole(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckInputelEment(int[,] array, int inputElement)
{
    if (inputElement > array.GetLength(0) || inputElement > array.GetLength(1))
    {
        Console.WriteLine("Input element not correct !");
    }
}

int[,] randomArray = GenerateArray2D(5, 5, 1, 100);
Console.WriteLine($"Yours array: ");
PrintArray2D(randomArray);
Console.WriteLine();
int inputRow = ReadConsole("Input number row: ");
CheckInputelEment(randomArray, inputRow);
int inputColumn = ReadConsole("Input number column: ");
CheckInputelEment(randomArray, inputColumn);
// FindeElement(randomArray, inputRow, inputColumn);