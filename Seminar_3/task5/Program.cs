//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве.

using static System.Console;
Clear();
Write("Введите координату X1: ");
int.TryParse(ReadLine(),out int x1);
Write("Введите координату Y1: ");
int.TryParse(ReadLine(),out int y1);
Write("Введите координату X2: ");
int.TryParse(ReadLine(),out int x2);
Write("Введите координату Y2: ");
int.TryParse(ReadLine(),out int y2);

double length= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));

WriteLine("Длина отрезка равна - " + length);