//  Напишите программу, которая определит "Счастливый билет" выданный в трамвае
// (сумма первых цифр равно сумме последних трех цифр).


using static System.Console;
// Clear();
Write("Введите номер билета: ");
string number = ReadLine()!;

WriteLine($"Билет {Lucky(number)} является счастливым");


string Lucky(string numb)
{
    int.TryParse(numb, out int a);
    string result = numb +" не";
    if ( a/100000+a/10000%10+a/1000%10== a/100%10 +a/10%10 + a%10) result = numb;
    return result;
}
