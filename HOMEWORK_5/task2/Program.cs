//  Напишите программу реализующую методы формирования массива, 
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();
int[] array = GetArray(10);
PrintArray(array);

WriteLine(OddSum(array));



int OddSum(int[] inArray)
{
    int result = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        result += i % 2 != 0 ? inArray[i] : 0;
    }

    return result;
}
int[] GetArray(int size)
{
    int[] resultArray = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(1, 10);
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