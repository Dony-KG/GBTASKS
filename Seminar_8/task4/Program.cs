// Из двумерного массива целых чисел удалить строку и столбец,
//  на пересечении которых расположен наименьший элемент.
using static System.Console;
Clear();

// WriteLine("Введите размер матрицы и диапозон значений через пробел: ");
// string[] parametrs = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,] matrix = GetMatrixArray(int.Parse(parametrs[0]), int.Parse(parametrs[1]), int.Parse(parametrs[2]), int.Parse(parametrs[3]));

int[,] matrix = new int[,] { { 11, 12, 13 }, { 21, 22, 23 }, { 31, 32, 1 } };
PrintMatrix(matrix);

WriteLine();
DeletRowAndColumn(matrix);


void DeletRowAndColumn(int[,] inMatrix)
{
    int min = inMatrix[0, 0];
    int k = 0, m = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (inMatrix[i, j] <= min)
            {
                min = inMatrix[i, j];
                k = i;
                m = j;
            }
        }

    }
    WriteLine($"Строка: {k}  Столбец: {m}  Минимум последний: {min}");

    int[,] result = new int[inMatrix.GetLength(0) - 1, inMatrix.GetLength(1) - 1];

    for (int i = 0, l = 0; i < inMatrix.GetLength(0); i++, l++)
    {
        if (i == k) i++;
        if (i < inMatrix.GetLength(0))
            for (int j = 0, n = 0; j < inMatrix.GetLength(1); j++, n++)
            {
                if (j == m) j++;
                if (j < inMatrix.GetLength(1))
                    result[l, n] = inMatrix[i, j];
            }

    }
    PrintMatrix(result);
}



//     int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
// {
//     Random rnd = new Random();
//     int[,] resultArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
//         }
//     }
//     return resultArray;
// }

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Console.Write($"{inMatrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}
