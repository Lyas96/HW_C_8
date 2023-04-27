/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


using System;
using static System.Console;

Clear();
Write("Введите число сторок: ");
int raws = int.Parse(ReadLine());
Write("Введите число столбцов: ");
int columns = int.Parse(ReadLine());
Write("Введите число: ");
int rawscolumns = int.Parse(ReadLine());
int[,,] array3d = GetArray(raws, columns, rawscolumns, 1, 99);
PrintArray(array3d);
WriteLine();

int[,,] GetArray(int a, int b, int c, int minValue, int maxValue)
{
  int[,,] result = new int[a, b, c];
  Random rnd = new Random();
  for (int i = 0; i < raws; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      for (int k = 0; k < rawscolumns; k++)
      {
        int variable = rnd.Next(1, 5);
        result[i, j, k] = rnd.Next(minValue, maxValue + 1);
        result[i, j, k] *= variable;
        result[i, j, k] -= (variable * 2);
      }
    }
  }
  return result;
}

void PrintArray(int[,,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      WriteLine();
      for (int k = 0; k < inArray.GetLength(2); k++)
      {
        Write($"{inArray[i, j, k]}({i},{j},{k}) ");
      }
    }
    WriteLine();
  }
}
