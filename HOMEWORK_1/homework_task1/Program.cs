/*  Напишите программу, которая принимает на вход три числа
 и выдаёт максимальное из этих чисел.*/

using static System.Console;

Write("Введите первое число: ");

int a = int.Parse(ReadLine()!);

Write("Введите второе число: ");

int b = int.Parse(ReadLine()!);

Write("Введите третье число: ");

int c = int.Parse(ReadLine()!);

int max = a;
 
if (max < b)

max = b;

if (max < c)

max = c;

Write($"Максимальное число {max}");