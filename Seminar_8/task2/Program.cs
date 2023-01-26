//  Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

using static System.Console;
Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


int[,] array = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[2]), int.Parse(parametrs[3]));

PrintMatrixArray(array);
WriteLine();
NewMatrix(array);


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}
void NewMatrix(int[,] inArray)
{
    int[,] result = new int[inArray.GetLength(0), inArray.GetLength(1)];

    if (inArray.GetLength(0) != inArray.GetLength(1))
    {

        WriteLine("Невозможно");

    }

    else
    {

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                result[j, i] = inArray[i, j];
            }
        }
        PrintMatrixArray(result);


    }
}