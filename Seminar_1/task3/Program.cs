/*5. Напишите программу, которая на вход принимает одно число (N),
 а на выходе показывает все целые числа в промежутке от -N до N.*/
using static System.Console;
Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int count = a*2;
int n = -a;

while (n<=a)
{
 Write($"{n}  ");

 n++;
}