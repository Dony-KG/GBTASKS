//  Напишите программу реализующую методы формирования массива, 
// заполненного случайными вещественными числами и вычисления разницы 
// между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;
Clear();
double[] array = GetArray(10, 1, 10);
PrintArray(array);

WriteLine($"Разница между Max и Min = {Dif(array):f2}");



double Dif(double[] inArray)
{
    double max = inArray[0];
    double min = inArray[0];
    foreach (var a in inArray)
    {
        max = a > max ? a : max;
        min = a < min ? a : min;
    }
    WriteLine($"Max = {max:f2},  Min = {min:f2} ");
    return max - min;
}


double[] GetArray(int size, int start, int end)
{
    double[] resultArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().NextDouble() * (end - start) + start;
    }

    return resultArray;
}

void PrintArray(double[] Array)
{
    Write("[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Write($"{Array[i]:f2}, ");
    }

    WriteLine($"{Array[Array.Length - 1]:f2}]");
}