// Напишите программу, которая принимает на вход 
//число и проверяет, кратно ли оно одновременно 7 и 23.

using static System.Console;
Write("Введите число: ");
int a = int.Parse(ReadLine()!);

WriteLine(a % 7 == 0 && a % 23 == 0 ?"кратно":"некратно");