// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml.XPath;

Console.Clear();
int inputCountRow = CheckCorrectInputRowsAndCollumns("Input count row: ");
int inputCountColumn = CheckCorrectInputRowsAndCollumns("Input count columns: ");
int inputRandomMin = ReadConsole("Input min random number: ");
int inputRandomMax = ReadConsole("Input max random number: ");

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
        Console.WriteLine("\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int CheckCorrectInputRowsAndCollumns(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) return number;
    else
    {
        Console.WriteLine("Please input positive number !");
        return CheckCorrectInputRowsAndCollumns(message);
    }
}

int ReadConsole(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void ArifmeticalMeanColumns(int[,] array)
{
    int i, j;
    Random random = new Random();
    for (j = 0; j < inputCountColumn; j++)
    {
        double sum = 0;
        for (i = 0; i < inputCountRow; i++)
        {
            sum = sum + array[i, j];
        }
        Console.WriteLine($"Arifmetical mean column {j}: {sum / (i):F1} ");
    }
}

int[,] randomArray = GenerateArray2D(inputCountRow, inputCountColumn, inputRandomMin, inputRandomMax);
Console.WriteLine($"Yours array: ");
PrintArray2D(randomArray);
Console.WriteLine();
ArifmeticalMeanColumns(randomArray);

