// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8


using static System.Console;
Clear();
Write("Введите число N для ряда Фибоначчи: ");
int number = int.Parse(ReadLine()!);

Fibonachi(number);


void Fibonachi(int numb)
{
    int[] array = new int [numb+1];
    if (numb==0) array[0] = 0;
    if (numb>=1) {array[0] = 0; array[1]=1;}

    int i=2;
    while (i<=numb)
    {
        array[i]= array[i-2]+array[i-1];
        i++;
    }

    for ( i = 0; i <= numb; i++)
    {
        Write($"{array[i]} ");
    }
}