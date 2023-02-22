// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumElementRow(int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] += matr[i, j];
        }

    }
    return sum;
}

void Result(int[] arr)
{
    int index = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            index = i;
            min = arr[i];
        }
    }
    System.Console.WriteLine($"Наименьшая сумма элементов находится на строке: {index + 1}");
}

int rows = ReadInt(" Введите количество строк матрицы: ");
int cols = ReadInt(" Введите количество столбцов матрицы: ");
System.Console.WriteLine();
var mymatrix = GenerateMatrix(rows, cols);
PrintMatrix(mymatrix);
System.Console.WriteLine();
int[] array = SumElementRow(mymatrix);
Result(array);