// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void NumberRowMinSumElements(int[,] matr)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        minRow = minRow + matr[0, i];
    }
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        sumRow = sumRow + matr[i, j];
        
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка с суммой элементов {minRow}");
}

Console.Clear();

Console.WriteLine("Введите m - количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n - количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
NumberRowMinSumElements(matrix);
