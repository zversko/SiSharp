﻿// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

int number(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void PrintArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void RandomArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(0, 10);
        }
    }
}

void ConvertToSqr(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            if( rows % 2 == 0 && columns % 2 == 0 )
            {
            matrix[rows, columns] = matrix[rows, columns] * matrix[rows, columns];
            }
        }
    }
}



void Main()
{
    int rows = number("Укажите количество строк");
    int columns = number("Укажите количество столбцов");
    int[,] matrix = new int[rows, columns];
    PrintArray(matrix);
    Console.WriteLine();
    RandomArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    ConvertToSqr(matrix);
    PrintArray(matrix);
    Console.WriteLine();
}

Main();