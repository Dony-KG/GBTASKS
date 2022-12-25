using static System.Console;
WriteLine("Является прервое число квадратом второго? ");
Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число:");
int b = int.Parse(ReadLine()!);

    if (b*b == a)
    {
        WriteLine("Да");
    }
    else
    {
        WriteLine("Нет");
    }