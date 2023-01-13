// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

using static System.Console;
Clear();
Write("Введите число : ");
int.TryParse(ReadLine(),out int number);
int mult = GetMult(number);
WriteLine($"Произведение чисел от 1 до {number} = {mult}");


int GetMult(int A)
{
int result = 1;

while(A > 0)
{
result *= A;
A--;
}
return result;
}