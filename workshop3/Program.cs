// 7. Показать числа от -N до N

// void Test7(int arg1, int[] col)
// {
//     int length = 2 * arg1 - 1;
//     int arg2 = -arg1;
//     for (int i = 0; i < length; i++)
//     {
//         arg2 = arg2 + 1;
//         col[i] = arg2;
//     }
// }

// Console.Clear();
// Console.WriteLine("Принимаем, что в задаче рассматривается числовой отрезок для целых чисел, т.к. ряд вещественных бесконечен");
// Console.WriteLine("Принимаем, что числа -N и N не входят в указанный диапазон, т.к. указано 'от' и 'до' ");
// WaitUser();

// Console.WriteLine("Введите N");
// int arg1 = UserInteger();

// Console.WriteLine($"Введено {arg1}");
// WaitUser();

// int[] col = new int[2 * arg1 - 1];
// Test7(arg1, col);

// PrintIntArray(col);

//Метод ожидающий ввода целочисленного числа, осуществляющий проверку ввода
// int UserInteger()
// {
//     int integerNumber = 0; //переменная integerNumber, в данном случае, хранит число, которое ввел пользователь
//     while (true)
//     {
//         Console.WriteLine("Введите целочисленное значение");
//         if (int.TryParse((Console.ReadLine()), out int number)) //извлекаем из строки ввода символы и пытаемся присвоить им вещественный тип числа
//         {
//             integerNumber = number;  //если получилось, запоминаем число
//             Console.Clear();
//             break;          //очищаем экран и выходим из цикла
//         }
//         else
//         {
//             Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); //если не получилось, запрашиваем по новой
//         }
//     }
//     return integerNumber;        // возвращаем значение метода (функции) в программу
// }

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

