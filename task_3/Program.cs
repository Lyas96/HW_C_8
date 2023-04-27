/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

using System;
using static System.Console;

Clear();
Write("Введите число сторок первой матрицы: ");
int raws1matrix = int.Parse(ReadLine());
Write("Введите число столбцов первой матрицы: ");
int columns1matrix = int.Parse(ReadLine());
Write("Введите число сторок второй матрицы: ");
int raws2matrix = int.Parse(ReadLine());
Write("Введите число столбцов второй матрицы: ");
int columns2matrix = int.Parse(ReadLine());
int[,] FirstMatrix = GetArray(raws1matrix, columns1matrix, 0, 10);
PrintArray(FirstMatrix);
WriteLine();
int[,] SecondMatrix = GetArray(raws2matrix, columns2matrix, 0, 10);
PrintArray(SecondMatrix);
WriteLine();
int[,] ResultMatrix = MyltiplicateMatrix(FirstMatrix, SecondMatrix);
PrintArray(ResultMatrix);


int[,] MyltiplicateMatrix (int[,] MatrixNumb1, int[,] MatrixNumb2)
{
  int[,] result = new int[MatrixNumb2.GetLength(0), MatrixNumb2.GetLength(1)];
  if (MatrixNumb1.GetLength(1) == MatrixNumb2.GetLength(0))
  {
    for (int i = 0; i < MatrixNumb1.GetLength(0); i++)
    {
      for (int j = 0; j < MatrixNumb2.GetLength(1); j++)
      {
        result[i, j] = 0;
        for (int k = 0; k < MatrixNumb1.GetLength(1); k++)
        {
          result[i, j] += MatrixNumb1[i, k] * MatrixNumb2[k, j];
        }
      }
    }
  }
  else
    {
      WriteLine(" Нельзя перемножить ");
    }
  return result;
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
