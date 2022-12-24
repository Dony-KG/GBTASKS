using static System.Console;
Clear();
Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

WriteLine(a/b==b?$"{a} является квадратом {b}":b/a==a?$"{b} является квадратом {a}":"числа не являются квадратом другого");