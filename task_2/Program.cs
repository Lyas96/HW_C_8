/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


using System;
using static System.Console;

Clear();
Write("Введите число сторок: ");
int raws = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(raws, columns, 0, 10);
PrintArray(array);
WriteLine();
int[] SumArray = SumLines(array);
WriteLine(String.Join(", ", SumArray));
WriteLine();
MinRow(SumArray);

int[] SumLines(int[,] inArray)
{
  int[] result = new int[inArray.GetLength(0)];
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      sum += inArray[i, j];
    }
    result[i] = sum;

  }
  return result;
}

void MinRow(int[] SumLinesArray)
{
  int MinEl = SumLinesArray[0];
  int index = 1;
  for (int i = 1; i < SumLinesArray.Length; i++)
  {
    if (SumLinesArray[i] < MinEl)
    {
      MinEl = SumLinesArray[i];
      index = i + 1;
    }
  }
  WriteLine($"Строка {index} является cтрокой с минимальной суммой элементов({MinEl})");
}

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
      Write($"{inArray[i, j]} ");
    }
    WriteLine();
  }
}


