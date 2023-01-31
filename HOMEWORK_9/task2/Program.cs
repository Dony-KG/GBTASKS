// Напишите программу, которая реализует рекурсивный метод 
//нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

WriteLine("Введите диапозон целых значений, которые нужно сложить, через пробел: ");
int[] num = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
WriteLine(SumNumber(num[0], num[1]));


int SumNumber(int start, int end)
{
    return start < end ? (start == end ? start : SumNumber(start, end - 1) + end)
                        : (start == end ? start : SumNumber(start, end + 1) + end);
}
