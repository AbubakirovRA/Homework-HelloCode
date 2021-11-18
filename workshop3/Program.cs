//Метод ожидающий ввода вещественного числа и осуществляющий проверку ввода
double UserDouble()
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

// 1. По двум заданным числам проверять является ли первое квадратом второго
double squareNumber(double arg)
{
    return (arg * arg);
}

bool Test(double arg1, double arg2)
{
    return arg1 == squareNumber(arg2);// возвращается логическое значение true или false
}

Console.WriteLine("Введите первое число");
double arg1 = UserDouble();

Console.WriteLine("Введите второе число");
double arg2 = UserDouble();

Console.WriteLine($"Введено {arg1} и {arg2}");

if (Test(arg1, arg2)) Console.WriteLine("Первое число является квадратом второго");// Если в конструкции if-else используются логические условия,
else Console.WriteLine("Первое число не является квадратом второго"); // то достаточно после if поставить условие, возвращающее true-значение, а после else значение false