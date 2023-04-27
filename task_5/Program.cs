/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


using System;
using static System.Console;

Clear();
Write("Введите число сторок: ");
int raws = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());
int[,] array = GetSpiral(raws, columns);
PrintArray(array);
WriteLine();


int[,] GetSpiral(int raws, int columns)
{
  int[,] SpiralArray = new int[raws, columns];
  int count = 1;
  int i = 0;
  int j = 0;
  if (SpiralArray.GetLength(0) == SpiralArray.GetLength(1))
  {
    while (count <= SpiralArray.GetLength(0) * SpiralArray.GetLength(1))
    {
      SpiralArray[i, j] = count;
      count++;
      if (i <= j + 1 && i + j < SpiralArray.GetLength(1) - 1)
      {
        j++;
      }
      else if (i < j && i + j >= SpiralArray.GetLength(0) - 1)
      {
        i++;
      }
      else if (i >= j && i + j > SpiralArray.GetLength(1) - 1)
      {
        j--;
      }
      else
      {
        i--;
      }
    }
  }
  else
  {
    WriteLine("Массив должен быть квадратным!");
  }
  return SpiralArray;
}

void PrintArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      if (inArray[i, j] < 10)
      {
        Write($"0{inArray[i, j]} ");
      }
      else
      {
        Write($"{inArray[i, j]} ");
      }
    }
    WriteLine();
  }
}
