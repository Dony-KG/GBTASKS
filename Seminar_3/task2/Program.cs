using static System.Console;

Write("Введите цифру дня недели: ");

int day = int.Parse(ReadLine()!);

switch (day)
{
    case 1: 
    {
        WriteLine("Это понедельник");
        break;
    }

    case 2:
    {
        WriteLine("Это вторник");
        break;
    }

    case 3:
    {
        WriteLine("Это среда");
        break;
    }

    case 4: 
    {
        WriteLine("Это четверг");
        break;
    }

    case 5: 
    {
        WriteLine("Это пятница");
        break;
    }

    case 6:
    {
        WriteLine("Это суббота");
        break;
    }

    case 7:
    {
        WriteLine("Это воскресенье");
        break;
    }
    default:
    {
        WriteLine("Вы ввели неправильную цифру");
        break;
    }
}