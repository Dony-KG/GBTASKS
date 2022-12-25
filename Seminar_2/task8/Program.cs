using static System.Console;
Clear();
Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

WriteLine(a==b?"=":a>b?">":"<");