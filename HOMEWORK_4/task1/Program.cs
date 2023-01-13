/*  Напишите программу, реализующую метод,который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B с использованием цикла.
В задаче не использвать стандартный метод Pow!
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

using static System.Console;

Write("Введите превое число: ");
int.TryParse(ReadLine(), out int number1);
Write("Введите второе число: ");
int.TryParse(ReadLine(), out int number2);

Write("Результат = " + VozvStep(number1,number2));


int VozvStep (int n1,int n2)
{
    if (n1 == 0) return 0;
    int result = 1;
    for (int i=0; i<n2; i++)
    result *= n1;
    return result;
}