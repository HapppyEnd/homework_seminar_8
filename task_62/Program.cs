//Задача 62: Заполните спирально массив 

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
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

int[,] SpiralMatr(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;

        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
        temp++;
    }
    return matrix;
}
int rows = ReadInt(" Введите количество строк матрицы: ");
int cols = ReadInt(" Введите количество столбцов матрицы: ");
PrintMatrix(SpiralMatr(rows, cols));