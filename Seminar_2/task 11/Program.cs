using static System.Console;
Clear();
Write("Введите количество банок первого стрелка: ");
int a = int.Parse(ReadLine()!);
Write("Введите количество банок второго стрелка: ");
int b = int.Parse(ReadLine()!);
int total = a + b - 1;
WriteLine("банок было " + total);