// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void FillArray(int x, int y, int z, int begin, int end)
{
    int[,,] matrix = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                if (matrix[i, j, k] == matrix[i, j, k])
                    matrix[i, j, k] = new Random().Next(begin, end + 1);
                Console.Write($"{matrix[i, j, k]}{(i, j, k)} ");
            }
        }
        Console.WriteLine();
    }
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int x = EnterData("Введите 1 размерность");
int y = EnterData("Введите 2 размерность");
int z = EnterData("Введите 3 размерность");

FillArray(x, y, z, 10, 100);
Console.WriteLine();