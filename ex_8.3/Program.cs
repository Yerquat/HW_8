// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void PrintProductMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)//, int line1, int columns1, int line2, int columns2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("произведение матриц не возможно");
    }
    else
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix1.GetLength(0); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

    }
    return result;
}

void PrintArray2(int[,] matr)
{
    for (int k = 0; k < matr.GetLength(0); k++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write(matr[k, n] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
int[,] TwoDimArray2(int line2, int columns2, int left, int right)
{
    int[,] array = new int[line2, columns2];
    for (int k = 0; k < line2; k++)
    {
        for (int n = 0; n < columns2; n++)
        {
            array[k, n] = new Random().Next(left, right);
        }
    }
    return array;
}

void PrintArray1(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] TwoDimArray1(int line1, int columns1, int left, int right)
{
    int[,] array = new int[line1, columns1];
    for (int i = 0; i < line1; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            array[i, j] = new Random().Next(left, right);
        }
    }
    return array;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int line1 = EnterData("Введите количество строк первой матрицы: ");
int columns1 = EnterData("Введите количество столбцов первой матрицы: ");
int line2 = EnterData("Введите количество строк второй матрицы: ");
int columns2 = EnterData("Введите количество столбцов второй матрицы: ");
int[,] matrix1 = TwoDimArray1(line1, columns1, 0, 10);  //Two-dimensional
PrintArray1(matrix1);
Console.WriteLine();
int[,] matrix2 = TwoDimArray2(line2, columns2, 0, 10);
PrintArray2(matrix2);
int[,] matrix3 = ProductMatrix(matrix1, matrix2);
PrintProductMatrix(matrix3);



