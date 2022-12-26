
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void Max(int summ, int[,] matrix, int rows, int columns)
// {
//     //int max = 0;
// for (int i = 0; i < rows; i++)

//     {

//         int max = 0;
//         for (int j = 0; j < columns; j++)
//         {   
//             summ = summ + matrix[i, j];

//         }
//          Console.WriteLine(max);


//     }

// }

void MinSummNumbers(int[,] matrix, int rows, int columns)
{
    int summ = 0;
    int minimum = 0;
    int index = 0;
    for (int i = 0; i < rows; i++)

    {
        summ = 0;
        for (int j = 0; j < columns; j++)
        {
            summ = summ + matrix[i, j];
        }
        Console.Write($"{summ}; ");

        if (i == 0) minimum = summ;
        if (summ < minimum)
        {
            minimum = summ;
            index = i;
        }
    }
    Console.WriteLine($"Минимальная сумма на строке {index} равна {minimum}");
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int rows, int columns, int begin, int end)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(begin, end + 1);
        }
    }
    return matrix;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int rows = EnterData("Введите количество строк");
int columns = EnterData("Введите количество столбцов");
int[,] matrix = FillArray(rows, columns, 1, 9);
PrintArray(matrix);
MinSummNumbers(matrix, rows, columns);

