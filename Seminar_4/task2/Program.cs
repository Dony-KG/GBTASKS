// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//8 -> 2
//89126 -> 5

using static System.Console;
Clear();
Write("Введите число : ");
int.TryParse(ReadLine(),out int num);
int count = GetCount(num);
WriteLine($"Число {num} состоит из  {count} чисел");


int GetCount(int A)
{
int result = 0;

while(A > 0)
{
 A /= 10;   
result ++;
}
return result;
}