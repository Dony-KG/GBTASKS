// Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N, 
// при условии, что N будет делиться на это число без остатка

using static System.Console;
Clear();
Write("Введите число : ");
int.TryParse(ReadLine(),out int number1);
int sum1 = GetSum(number1);
WriteLine($"Результат = {sum1}");


int GetSum(int A)
{
int result = 0;
int i = A;
while(i > 0)
{ if (A % i == 0)
result += i;
i--;
}
return result;
}
