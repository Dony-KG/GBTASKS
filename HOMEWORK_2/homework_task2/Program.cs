﻿/*   Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. */

using static System.Console;
//Write("Введите число: ");
//int a = int.Parse(ReadLine()!);
int a= new Random().Next(1,9999999);
WriteLine(a>999 ? $"Третья цифра числа {a} является: {a%1000/100}"
        : a<100 ? $"Третьей цифры числа {a} нет" 
        : $"Третья цифра числа {a} является: {a/100}");