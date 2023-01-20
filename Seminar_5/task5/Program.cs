//  Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.


using static System.Console;
Clear();

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int[] array1 = NumberPair(array);

PrintArray(array1);

int[] NumberPair(int[] inArray)
{
    int size = inArray.Length / 2;
    if (inArray.Length % 2 != 0) size++;

    int[] result = new int [size];

    for (int i = 0; i < size; i++)
    {
        result[i]= inArray[i]*inArray[inArray.Length-i-1];
    }
    return result;
}

void PrintArray(int[] Array)
{
    Write("[");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Write($"{Array[i]}, ");
    }

    WriteLine($"{Array[Array.Length - 1]}]");
}
