// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

Write("Введите b1: ");
double b1= double.Parse(ReadLine()!);
Write("Введите k1: ");
double k1= double.Parse(ReadLine()!);

Write("Введите b2: ");
double b2= double.Parse(ReadLine()!);
Write("Введите k2: ");
double k2= double.Parse(ReadLine()!);

Formula(b1,k1,b2,k2);

void Formula(double B1, double K1, double B2, double K2)
{
Write($"Точка пересечения в координате ( {(B2 - B1) / (K1 - K2)}, {K1 * ((B2 - B1) / (K1 - K2)) + B1} )");
}


