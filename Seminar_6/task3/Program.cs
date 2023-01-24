// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);

Write($"Число {number} в двоичной системе будет: {DecimalToBinary(number)}");


string DecimalToBinary(int numb)
{
    if (numb == 0) return "0";
    string result = string.Empty;
    int rem;
    while (numb > 0)
    {
        rem = numb % 2;
        numb /= 2;
        result = rem.ToString() + result;
    }
    return result;
}