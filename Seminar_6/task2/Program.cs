//  Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.

using static System.Console;
Clear();
Write("Введите три стороны треугольника через пробел: ");
string[] sides = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine(Triangle(sides) ? "Треугольник с такими сторонами существует":"Треугольник с такими сторонами не существует");

bool Triangle(string[] side)
{
if (int.Parse(side[0]) + int.Parse(side[1])>int.Parse(side[2]) &&
    int.Parse(side[1]) + int.Parse(side[2])>int.Parse(side[0]) &&
    int.Parse(side[0]) + int.Parse(side[2])>int.Parse(side[1])) return true;

return false;
}