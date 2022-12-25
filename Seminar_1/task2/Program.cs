using static System.Console;

Write("Введите цифру дня недели: ");

int day = int.Parse(ReadLine()!);

if (day < 7 && day > 1)
{
    if (day == 1) 
    {
        WriteLine("Это понедельник");
    }

        if (day == 2) 
        {
        WriteLine("Это вторник");
        }

            if (day == 3) 
            {
            WriteLine("Это среда");
            }

                if (day == 4) 
                {
                WriteLine("Это четверг");
                }

                    if (day == 5) 
                    {
                    WriteLine("Это пятница");
                    }

                        if (day == 6) 
                        {
                        WriteLine("Это суббота");
                        }

                            if (day == 6) 
                            {
                            WriteLine("Это воскресенье");
                            }
}
else
{
WriteLine("Вы ввели неправильную цифру");
}