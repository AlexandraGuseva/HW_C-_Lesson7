﻿// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.Write("Input count rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = new double[m, n];
// int randomnumber = new Random().Next(1,100);
// Methods
void FeelArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int randomnumber = new Random().Next(-100, 100);
            array[i, j] = new Random().NextDouble() + randomnumber;
        }
    }
    Console.WriteLine();
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]:F2} ");
        }
        Console.WriteLine();
    }
}

FeelArray(randomArray);
PrintArray(randomArray);