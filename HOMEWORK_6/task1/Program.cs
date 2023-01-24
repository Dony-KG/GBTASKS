//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

using static System.Console;
Clear();
Write("Введите массив через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"Было введено {PosCount(array)} чисел больше 0.");


int PosCount(string[] inArray)
{
    int i=0;
    foreach (var item in inArray)
    {
        if (int.Parse(item)>0) i++;
    }
    return i;
}