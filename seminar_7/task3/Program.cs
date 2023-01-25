// Задайте двумерный массив. Найдите элементы, 
//у которых оба индекса чётные, и замените эти элементы на их квадраты.

using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


int[,] array = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[1]), int.Parse(parametrs[3]));

PrintMatrixArray(array);
PowMatrixArray(array);
WriteLine();
PrintMatrixArray(array);

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

void PowMatrixArray(int[,] inArray)
{
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        for (int j = 1; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) inArray[i, j] *= inArray[i, j];
        }
    }
}