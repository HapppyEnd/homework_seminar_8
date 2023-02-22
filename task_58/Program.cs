// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
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

int[,] MultiplicationMatrix(int[,] matr1, int[,] matr2)
{
    int[,] newmatr = new int[matr1.GetLength(0), matr2.GetLength(1)];

    if (matr1.GetLength(1) == matr2.GetLength(0))
    {
        for (int i = 0; i < newmatr.GetLength(0); i++)
        {
            for (int j = 0; j < newmatr.GetLength(1); j++)
            {
               
                for (int k = 0; k < matr1.GetLength(1); k++)
                {
                    newmatr[i, j] += matr1[i, k] * matr2[k, j];
                }
            }
        }
    }
    return newmatr;
}
int rows = ReadInt(" Введите количество строк матрицы: ");
int cols = ReadInt(" Введите количество столбцов матрицы: ");
int rows2 = ReadInt(" Введите количество строк 2 матрицы: ");
int cols2 = ReadInt(" Введите количество столбцов 2 матрицы: ");
System.Console.WriteLine();
var mymatrix = GenerateMatrix(rows, cols);
var mymatrix2 = GenerateMatrix(rows2, cols2);
PrintMatrix(mymatrix);
System.Console.WriteLine();
PrintMatrix(mymatrix2);
System.Console.WriteLine();
PrintMatrix(MultiplicationMatrix(mymatrix, mymatrix2));