/* Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */
using static System.Console;

Write("Введите число: ");
int.TryParse(ReadLine(), out int number);

Write("Результат = " + Sum (number));


int Sum (int n1)
{
    if (n1 == 0) return 0;
    int n2=Math.Abs(n1);
    int result = 0;
    int i=0;
    while (n2 > 0)//вычисление сколькозначное число
    {
        n2/=10;
        i++;
    }
    int c=0;
    for(int j=i-1;j>=0; j--)
    {
        int des=Convert.ToInt32(Math.Pow(10,j));
        c=n1/des;
        result += c;
        n1= n1-c*des;
    }

    return result;
}