//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
using static System.Console;
Clear();
Write("Введите число : ");
int.TryParse(ReadLine(),out int number1);
int sum1 = GetSum(number1);
WriteLine($"Сумма чисел от 1 до {number1} = {sum1}");

Write("И еще раз введите число : ");
int.TryParse(ReadLine(),out int number2);
int sum2 = GetSum(number2);
WriteLine($"Сумма чисел от 1 до {number2} = {sum2}");


int GetSum(int A)
{
int result = 0;

while(A > 0)
{
result += A;
A--;
}
return result;
}