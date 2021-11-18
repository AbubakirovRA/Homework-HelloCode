// 4. Найти максимальное из трех чисел
// double Compare(double[] array) // этот  метод отвечает за нахождение максимального числа во введенном аргументе
// {
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//     }
//     return max;
// }

// void FillArray(double[] collection) // Объявляем метод FillArray, который будет заполнять массивы 
// {
//     int length = collection.Length; //присваиваем переменной length значение, соответствующее количеству
//                                     //элементов в аргументе collection
//     int index = 0;                  //устанавливаем счетчик index в нуль
//     while (index < length)          //запускаем заполнение объявляя цикл до значения переменной length
//     {                                                        // тело цикла
//         Console.WriteLine($"Введите {index} элемент");
//         collection[index] = Convert.ToDouble(UserDouble());  //заполняем аргумент collection числами                          
//         Console.Clear();
//         index++;                                             //увеличиваем инкремент
//     }
// }

// void PrintArray(double[] col)      // этот метод отвечает за вывод на экран содержимого массивов
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

// ТЕЛО ПРОГРАММЫ
// Console.Clear();
// Console.WriteLine("Сколько чисел будем сравнивать?");
// double[] A = new double[UserNatural()];
// FillArray(A);
// Console.WriteLine("Введены числа:");
// PrintArray(A);
// Console.WriteLine($"Максимальное число {Compare(A)}");


//Альтернативное решение от коллективного разума
// int Max(int a, int b, int c)
// {
//     int max = a;
//     if (b > max) max = b;
//     if (c > max) max = c;
//     return max;
// }
// Console.WriteLine($"Максимальное число {Max(15, 9, 11)}");

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
