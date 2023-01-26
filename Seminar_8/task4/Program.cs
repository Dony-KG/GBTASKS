// Из двумерного массива целых чисел удалить строку и столбец,
//  на пересечении которых расположен наименьший элемент.
using static System.Console;
Clear();

int[,] matrix = CreateRandomMatrix();
PrintMatrix(matrix);

WriteLine();
ExchangeRowsFirstToLast(matrix);


void ExchangeRowsFirstToLast(int[,] inMatrix)
{
    int[,] result = new int[inMatrix.GetLength(0) - 1, inMatrix.GetLength(1) - 1];
    for (int i = 0; i < inMatrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1) - 1; j++)
        {
            result[i, j] = inMatrix[i, j];
        }

    }
    PrintMatrix(result);
}



int[,] CreateRandomMatrix()
{
    Random rand = new Random();
    int rows = rand.Next(1, 11); int columns = rand.Next(1, 11);
    int minValue = rand.Next(-100, 0); int maxValue = rand.Next(0, 101);
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rand.Next(minValue, maxValue);
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
            Console.Write($"{inMatrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}