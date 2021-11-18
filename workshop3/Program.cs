// 3. По заданному номеру дня недели вывести его название
string WeekDay() // метод, возвращающий имя дня недели, в зависимости от введенного номера дня недели
{
    int arg;
    do
    {
        arg = 0;
        Console.WriteLine("Введите день недели (число от 1 до 7)");
        arg = Convert.ToInt32(UserNatural());
    }
    while (arg > 7);
    Console.WriteLine($"Введено {arg}");
    DateTime someDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, arg);
    string day = Convert.ToString(someDate.DayOfWeek);
    return day;
}
Console.WriteLine(WeekDay());

// string WeekDay(int current)
// {
//     string[] week = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
//     return week[current-1];
// }
// Console.WriteLine("Сегодня " + WeekDay(3));

//Метод ожидающий ввода целочисленного числа, осуществляющий проверку ввода
int UserNatural()
{
    int integerNumber = 0; //переменная integerNumber, в данном случае, хранит число, которое ввел пользователь
    while (true)
    {
        Console.WriteLine("Введите целочисленное значение");
        if (int.TryParse((Console.ReadLine()), out int number)) //извлекаем из строки ввода символы и пытаемся присвоить им вещественный тип числа
        {
            if (number > 0)
            {
                integerNumber = number;  //если получилось, запоминаем число
                Console.Clear();
                break;          //очищаем экран и выходим из цикла
            }
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); //если не получилось, запрашиваем по новой
        }
    }
    return integerNumber;        // возвращаем значение метода (функции) в программу
}