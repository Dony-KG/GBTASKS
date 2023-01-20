// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

using static System.Console;
Clear();

int[] array = GetArray(123, 10, 99);

PrintArray(array);
WriteLine();
WriteLine(ArrayCount(array));

int ArrayCount(int[] InArray)
{
    int result = 0;
    foreach (int i in InArray)
    {
        if (i >=10 && i <=99) result++;
    }
    return result;
}
int [] GetArray( int size, int minValue, int maxValue)
{
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue +1);
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
