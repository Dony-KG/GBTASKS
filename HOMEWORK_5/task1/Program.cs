//  Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, 
// и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;
Clear();
int[] array = GetArray(10);
PrintArray(array);
WriteLine(HonestCount(array));



int HonestCount(int[] inArray)
{
    int result = 0;
    foreach (var a in inArray)
    {
        result += a % 2 == 0 ? 1 : 0;
    }

    return result;
}
int[] GetArray(int size)
{
    int[] resultArray = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(100, 1000);
    }

    return resultArray;
}

void PrintArray(int[] Array)
{
    Write("[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Write($"{Array[i]}, ");
    }

    WriteLine($"{Array[Array.Length - 1]}]");
}