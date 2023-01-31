// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 30);
        }
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

Console.Clear();

Console.WriteLine("Введите m - количество строк первой матрицы");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n - количество столбцов первой матрицы и количество строк второй");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите p - количество столбцов второй матрицы");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = new int[m, n];
FillArray(firstMatrix);
PrintArray(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = new int[n, p];
FillArray(secondMatrix);
PrintArray(secondMatrix);
Console.WriteLine();

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц будет равно следующей матрице:");
PrintArray(resultMatrix);

