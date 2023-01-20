//  Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

using static System.Console;
Clear();

Write("Введите размер массива, мин и макс через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));

PrintArray(array);
WriteLine();
ReverseArray(array);
PrintArray(array);


int [] GetArray( int size, int minValue, int maxValue){
    int[] resultArray = new int [size];

    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue +1);
    }

    return resultArray;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] *= -1;
    }

}

void PrintArray(int[] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1]}]");
}