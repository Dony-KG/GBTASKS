// Из двумерного массива целых чисел удалить строку и столбец,
//  на пересечении которых расположен наименьший элемент.
using static System.Console;
Clear();

WriteLine("Введите размер матрицы и диапозон значений через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] matrix = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrix(matrix);
WriteLine();

DeleteRowsAndColumnsWhithMin(matrix);

void DeleteRowsAndColumnsWhithMin(int[,] inMatrix)
{
    int minValue = FindMinValue(inMatrix);

    int[,] result = new int[inMatrix.GetLength(0), inMatrix.GetLength(1)];

    int[] indexRowsAndColumns = FindIndexMinRowsAndColumns(inMatrix);

    for (int k = 0; k < indexRowsAndColumns.Length; k += 2)
    {
        int row = indexRowsAndColumns[k];
        int column = indexRowsAndColumns[k + 1];

        for (int i = 0; i < inMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inMatrix.GetLength(1); j++)
            {
                result[i, j] = (i == row || j == column) ? 0 : inMatrix[i, j];
            }

        }
        for (int i = 0; i < inMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inMatrix.GetLength(1); j++)
            {
                inMatrix[i, j] = result[i, j];
            }
        }
    }
    PrintMatrixWhithNoNull(result); WriteLine();
}




int FindMinValue(int[,] inMatrix)
{
    int minValue = inMatrix[0, 0];
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (minValue > inMatrix[i, j])
            {
                minValue = inMatrix[i, j];
            }
        }

    }
    return minValue;
}

int CountMinValue(int[,] inMatrix)
{
    int inMinValue = FindMinValue(inMatrix);
    int counter = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            counter += inMinValue == inMatrix[i, j] ? 1 : 0;
        }
    }
    return counter;
}

int[] FindIndexMinRowsAndColumns(int[,] inMatrix)
{
    int minValue = FindMinValue(inMatrix);
    int[] result = new int[CountMinValue(inMatrix) * 2];
    int counter = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (minValue == inMatrix[i, j])
            {
                result[counter] = i;
                result[counter + 1] = j;
                counter += 2;
            }
        }
    }
    return result;
}

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

void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j],4} ");
        }
        WriteLine();
    }
}

void PrintMatrixWhithNoNull(int[,] inMatrix)
{
    int k = 0;
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            if (inMatrix[i, j] != 0)
            {
                Write($"{inMatrix[i, j],4} ");
                k = j;
            }
            
        }
        if (inMatrix[i, k] != 0) WriteLine();
    }
}