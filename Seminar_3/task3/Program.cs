//Определение четверти на координатах

using static System.Console;
Clear();
Write("Введите X: ");
int x = int.Parse(ReadLine()!);
Write("Введите Y: ");
int y = int.Parse(ReadLine()!);


if (x>0 && y>0)
{
    WriteLine("Первая четверть");
}
if (x<0 && y>0)
{
    WriteLine("Вторая четверть");
}
if (x<0 && y<0)
{
    WriteLine("Третья четверть");
}
if (x>0 && y<0)
{
    WriteLine("Четвертая четверть");
}