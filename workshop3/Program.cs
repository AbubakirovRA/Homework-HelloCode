// 8. Показать четные числа от 1 до N

// int[] TestEven(int arg)
// {
//     int length = arg / 2;
//     int[] Even = new int[arg / 2];
//     int j = 1;
//     for (int i = 0; i < length; i++)
//     {
//         Even[i] = j++ * 2;
//     }
//     return Even;
// }

// Console.Clear();
// Console.WriteLine("Принимаем, что в задаче рассматривается числовой отрезок для натуральных (>0) чисел, т.к. ряд вещественных бесконечен");
// WaitUser();

// Console.WriteLine("Введите N");
// int arg = UserNatural();
// Console.WriteLine($"Введено {arg}");
// even(arg);
// if (even(arg))
// {
//     if (arg > 2) PrintIntArray(TestEven(arg - 1));
// }
// else
// {
//     PrintIntArray(TestEven(arg));
// }

// ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ

//метод (процедура) ожидание пользователя, для того, чтобы дать прочитать условие
// void WaitUser()
// {
//     Console.WriteLine("Нажмите ENTER, когда будете готовы продолжить");
//     while (true)
//     {                                                       //цикл повторяется до тех пор, пока
//         if (Convert.ToString(Console.ReadLine()) == "")     //не нажата клавиша Enter
//         {
//             break;                                          //по выполнению условия прерываю цикл
//         }
//     }
// }

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



// этот метод отвечает за вывод на экран содержимого массивов
// void PrintIntArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }
//     Console.WriteLine();
// }