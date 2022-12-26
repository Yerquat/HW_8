// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] SpiralFillArray(int[,] array)
{
    int i = 0;
    int j = 0;
        for(int count = 1; count <= 16; count++)
        {
            array[i, j] = count;
            if (i <= j + 1 && i + j < 3) j++;
            else if (i < j && i + j >= 3) i++;
            else if (i >= j && i + j > 3) j--;
            else i--;
        }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
array = SpiralFillArray(array);
PrintArray(array);