// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

using static System.Console;

Clear();
WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);
WriteLine();
WriteLine($"Сумма диагонали равно: {PrintDiagArray(array)}");



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

int PrintDiagArray(int[,] inArray)
{
    int sum = 0;

    for (int i = 0; i < ((inArray.GetLength(0) < inArray.GetLength(1)) ? inArray.GetLength(0) : inArray.GetLength(1)); i++)
    {
        sum += inArray[i, i];
    }

    return sum;
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