// Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

using static System.Console;
Clear();
Write("Введите координату X, точки A: ");
int.TryParse(ReadLine(),out int x1);

Write("Введите координату Y, точки A: ");
int.TryParse(ReadLine(),out int y1);

Write("Введите координату Z, точки A: ");
int.TryParse(ReadLine(),out int z1);

Write("\nВведите координату X, точки B: ");
int.TryParse(ReadLine(),out int x2);

Write("Введите координату Y, точки B: ");
int.TryParse(ReadLine(),out int y2);

Write("Введите координату Z, точки B: ");
int.TryParse(ReadLine(),out int z2);

double length= Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));

WriteLine($"Длина отрезка равна: {length:f2}");  //f2 - округление после зяпятой, до 2 х знаков, p - проценты
