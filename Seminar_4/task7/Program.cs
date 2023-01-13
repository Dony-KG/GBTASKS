
using static System.Console;
//Clear();
WriteLine("Введите длинну массива");
int.TryParse(ReadLine(),out int size);
WriteLine("Введите диапозон чисел (включительно) от: ");
int.TryParse(ReadLine(),out int num1);
WriteLine("до: ");
int.TryParse(ReadLine(),out int num2);


int [] arr = GetArray(size, num1, num2);

PrintArray(arr);


int[] GetArray (int Size, int Num1, int Num2)
{
int [] array = new int [Size];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(Num1, Num2+1);
}
return array;
}

void PrintArray (int [] array)
{
for (int i = 0; i < array.Length; i++)
{
Write($"{array[i]} ");
}
}