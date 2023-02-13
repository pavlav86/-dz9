// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void ShowRow(int[,] array)
{
  int tempSum = 0;
  int sum = tempSum;
  int index = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      tempSum += array[i, j];
    }
    if (i == 0)
    {
      sum = tempSum;
      tempSum = 0;
      continue;
    }
    if (tempSum < sum)
    {
      sum = tempSum;
      index = i;
    }
    tempSum = 0;
  }
  Console.WriteLine($"Line number with minimum amount: {index + 1}");
}

void ShowMatrix(int[,] matrix)
{

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
  }
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int[,] GetMatrix()
{
  Console.WriteLine("Enter matrix MxN:");
  int m = GetNumber("M = ");
  int n = GetNumber("N = ");
  int[,] arr = new int[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      arr[i, j] = new Random().Next(0, 10);
    }
  }
  return arr;
}

int[,] matrix = GetMatrix();
ShowMatrix(matrix);
Console.WriteLine();
ShowRow(matrix);
