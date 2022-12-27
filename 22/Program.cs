﻿// Среднее арифметическое элементов в каждом столбце двумерного массива.

System.Console.WriteLine("Введите длину массива:");
int length = ReadInt();
System.Console.WriteLine("Введите ширину массива:");
int secondLength = ReadInt();
int[,] array = GetArray(length, secondLength);
PrintArray(array);
Console.ReadLine();
Average(array);
double a;

int ReadInt() 
{
    return int.Parse(Console.ReadLine());
}

int[,] GetArray (int length, int secondLength)
{
    int[,] array = new int[length, secondLength]; 
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < secondLength; j++)
        {
            array[i, j] = random.Next(10); 
        }
    }
    return array;
}

void PrintArray (int[,] array)
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

void Average(int[,] array)
{
    double sum = 0;
    double a = 0;
    for (int col = 0; col < secondLength; col++ )
    {
        sum = 0; 
       for (int row = 0; row < length; row++ )
       {
        sum += array[row, col];
       }
       a = (sum/length);
       Console.Write($"{a} ");
    }
}