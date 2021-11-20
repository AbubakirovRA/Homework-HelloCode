// 6. Выяснить является ли число чётным

// bool even(double arg)
// {
//     return arg % 2 == 0;
// }

// double arg = UserDouble();
// even(arg);

// if (even(arg)) Console.WriteLine($"Число {arg} - четное");
// else Console.WriteLine($"Число {arg} - нечетное");

//Метод ожидающий ввода вещественного числа и осуществляющий проверку ввода
// double UserDouble()
// {
//     double Number = 0; //переменная Number, хранит вещественное число, которе вводит пользователь
//     while (true)
//     {
//         Console.WriteLine("Введите вещественное значение");
//         if (double.TryParse((Console.ReadLine()), out double number)) //извлекаем из строки ввода символы и пытаемся присвоить им вещественный тип числа
//         {
//             Number = number;  //если получилось, запоминаем число
//             Console.Clear();
//             break;          //очищаем экран и выходим из цикла
//         }
//         else
//         {
//             Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); //если не получилось, запрашиваем по новой
//         }
//     }
//     return Number;        // возвращаем значение метода (функции) в программу
// }
