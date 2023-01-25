using static System.Console;
Clear();

Write("Введите адрес клетки:: ");
string addres = ReadLine()!;
WriteLine((addres[0] + addres[1]) % 2 == 0 ? "Черная" : "Белая");