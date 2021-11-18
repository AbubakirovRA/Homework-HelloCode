// 2. Даны два числа. Показать большее и меньшее число

double UserDouble()  //Метод ожидающий ввода вещественного числа и осуществляющий проверку ввода
{
    double Number = 0; //переменная Number, хранит вещественное число, которе вводит пользователь
    while (true)
    {
        Console.WriteLine("Введите вещественное значение");
        if (double.TryParse((Console.ReadLine()), out double number)) //извлекаем из строки ввода символы и пытаемся присвоить им вещественный тип числа
        {
            Number = number;  //если получилось, запоминаем число
            Console.Clear();
            break;          //очищаем экран и выходим из цикла
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); //если не получилось, запрашиваем по новой
        }
    }
    return Number;        // возвращаем значение метода (функции) в программу
}

bool Test1(double arg1, double arg2)
{
    return arg1 > arg2;
}

Console.WriteLine("Введите первое число");
double arg1 = UserDouble();
Console.WriteLine("Введите второе число");
double arg2 = UserDouble();
Console.WriteLine($"Введено {arg1} и {arg2}");
Test1(arg1, arg2);

if (Test1(arg1, arg2)) Console.WriteLine($"Большее число - {arg1}, меньшее число {arg2}");
else Console.WriteLine($"Большее число - {arg2}, меньшее число {arg1}");