// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] МatrixМultiplication(int[,] first, int[,] second)
{
  int[,] multiMatrix = new int[first.GetLength(0), second.GetLength(1)];
  int count = 0;
  for (int i = 0; i < multiMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < multiMatrix.GetLength(1); j++)
    {
      for (int k = 0; k < second.GetLength(0); k++)
      {
        multiMatrix[i,j] = multiMatrix[i,j] + first[i,k] * second[k,j];
      }
    }
  }
  return multiMatrix;
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

int[,] GetMatrix(int m, int n)
{
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

int[,] firstMatrix = GetMatrix(4,3);
int[,] secondMatrix = GetMatrix(3,4);
ShowMatrix(firstMatrix);
Console.WriteLine();
ShowMatrix(secondMatrix);
Console.WriteLine();
int[,] multiMatrix = МatrixМultiplication(firstMatrix, secondMatrix);
ShowMatrix(multiMatrix);
