/* Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.*/

using static System.Console;
Clear();
int number=new Random().Next(100,999);
WriteLine(number);
int first=number/100;
int last=number%10;

Write($"{first}{last}");