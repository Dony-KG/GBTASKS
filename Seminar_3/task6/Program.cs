//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
using static System.Console;
Clear();
Write("Введите число для вывода таблицы квадратов от 1 до числа : ");
int.TryParse(ReadLine(),out int n);
int i=1;

while(i<=n)
{
Write($" {Math.Pow(i,2)} |");
i++;
}
