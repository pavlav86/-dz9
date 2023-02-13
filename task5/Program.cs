// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] GetSpiralMatrix(int m, int n)
{
  int[,] arr = new int[m, n];
  int count = 0;
  for (int i = 0; i < m - 1 - i; i++)
  {
    for (int j = i; j < n - 1 - i; j++)
    {
      arr[i, j] = ++count;
    }
    for (int j = i; j < m - 1 - i; j++)
    {
      arr[j, n - 1 - i] = ++count;
    }
    for (int j = m - 1 - i; j > i; j--)
    {
      arr[n - 1 - i, j] = ++count;
    }
    for (int j = m - 1 - i; j > i; j--)
    {
      arr[j, i] = ++count;
    }
  }
  if (m % 2 != 0 && n%2 != 0)
    arr[m/2, n/2] = ++count;
  return arr;
}

int[,] matrix = GetSpiralMatrix(5, 5);
ShowMatrix(matrix);
