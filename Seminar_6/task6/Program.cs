// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using static System.Console;
Clear();
int[] array = GetArray(10);
PrintArray(array);

int[] array2 = CopyArray(array);
WriteLine();
PrintArray(array);

int [] GetArray( int size)
{
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(1,10);
    }

    return resultArray;
}

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1]}]");
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int [inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}