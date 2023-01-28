//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;

Clear();
WriteLine("Введите размер квадратной матрицы и диапозон целых значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] matrix = GetMatrix(intParams[0], intParams[1], intParams[2]);
int[,] matrix1 = GetMatrix(intParams[0], intParams[1], intParams[2]);


PrintMatrix(matrix);
WriteLine();
PrintMatrix(matrix1);
WriteLine();
PrintMatrix(MultMatrix(matrix,matrix1));




int[,] MultMatrix(int[,] inMatrix1,int[,] inMatrix2)
{
     

    int[,] resultMutrix = new int[inMatrix1.GetLength(0),inMatrix1.GetLength(1)];
    for (int i = 0; i < inMatrix1.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix1.GetLength(1); j++)
        {
            for (int k = 0; k < inMatrix1.GetLength(1); k++)
            resultMutrix[i,j] += inMatrix1[i, k]*inMatrix2[k, j];
        }
    }
    
    return resultMutrix;
}


int[,] GetMatrix(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultMatrix = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            resultMatrix[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultMatrix;
}



void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j],3} ");
        }
        WriteLine();
    }
}