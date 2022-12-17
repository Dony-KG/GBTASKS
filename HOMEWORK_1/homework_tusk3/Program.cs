/*   Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/

using static System.Console;

int N;

do
{
Write("Введите число больше 1-го: ");

N = int.Parse(ReadLine()!);

if (N < 2)

WriteLine("Введеное число не соответсвует условию задачи, ваше число меньше 2-х.");

}
 
while (N < 2) ;

int count = 2;

do 
{
Write($"{count} ");

count+=2;
}
while(count <= N);