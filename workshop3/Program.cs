// Почувствуй себя интерном
//-------------------------
// 0. Вывести квадрат числа
double squareNumber(double arg)
{
    return (arg * arg);
}
// Console.WriteLine($"Квадрат введенного числа равен {squareNumber(UserDouble())}");







// 1. По двум заданным числам проверять является ли первое квадратом второго
// int Test(double arg1, double arg2)
// {
//     int flag = 0;
//     if (arg1 == squareNumber(arg2)) flag = 1; //Console.WriteLine("Первое число является квадратом второго");
//     else flag = 2; //Console.WriteLine("Первое число не является квадратом второго");
//     return flag;
// }

bool Test(double arg1, double arg2)
{
    return arg1 == squareNumber(arg2);// возвращается логическое значение true или false
}

// Console.WriteLine("Введите первое число");

// double arg1 = UserDouble();
// Console.WriteLine("Введите второе число");
// double arg2 = UserDouble();
// Console.WriteLine($"Введено {arg1} и {arg2}");

// if (Test(arg1, arg2)) Console.WriteLine("Первое число является квадратом второго");// Если в конструкции if-else используются логические условия,
// else Console.WriteLine("Первое число не является квадратом второго"); // то достаточно после if поставить условие, возвращающее true-значение, а после else значение false




// 2. Даны два числа. Показать большее и меньшее число
// bool Test1(double arg1, double arg2)
// {
//     return arg1 > arg2;
// }

// Console.WriteLine("Введите первое число");
// double arg1 = UserDouble();
// Console.WriteLine("Введите второе число");
// double arg2 = UserDouble();
// Console.WriteLine($"Введено {arg1} и {arg2}");
// Test1(arg1, arg2);

// if (Test1(arg1, arg2)) Console.WriteLine($"Большее число - {arg1}, меньшее число {arg2}");
// else Console.WriteLine($"Большее число - {arg2}, меньшее число {arg1}");





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

// Console.WriteLine(WeekDay());



// string WeekDay(int current)
// {
//     string[] week = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};
//     return week[current-1];
// }
// Console.WriteLine("Сегодня " + WeekDay(3));





// 4. Найти максимальное из трех чисел
double Compare(double[] array) // этот  метод отвечает за нахождение максимального числа во введенном аргументе
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

void FillArray(double[] collection) // Объявляем метод FillArray, который будет заполнять массивы 
{
    int length = collection.Length; //присваиваем переменной length значение, соответствующее количеству
                                    //элементов в аргументе collection
    int index = 0;                  //устанавливаем счетчик index в нуль
    while (index < length)          //запускаем заполнение объявляя цикл до значения переменной length
    {                                                        // тело цикла
        Console.WriteLine($"Введите {index} элемент");
        collection[index] = Convert.ToDouble(UserDouble());  //заполняем аргумент collection числами                          
        Console.Clear();
        index++;                                             //увеличиваем инкремент
    }
}

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






// 5. Написать программу вычисления значения функции y=f(a)
double Sinus()
{
    Console.WriteLine("Введите значение а");
    string A = Console.ReadLine();
    double a = double.Parse(A);
    return Math.Sin(a);
}

// Console.WriteLine(Sinus()); 





// 6. Выяснить является ли число чётным

bool even(double arg)
{
    return arg % 2 == 0;
}

// double arg = UserDouble();
// even(arg);

// if (even(arg)) Console.WriteLine($"Число {arg} - четное");
// else Console.WriteLine($"Число {arg} - нечетное");





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





// 9. Показать последнюю цифру трёхзначного числа

// Console.Clear();
// ПЕРВОЕ РЕШЕНИЕ
// int num = 456;
// int Test9(int arg)
// {
//     return arg % 10;
// }
// Console.WriteLine(Test9(num));

// ВТОРОЕ РЕШЕНИЕ
// Console.WriteLine("Введите трехзначное число");
// string text = Console.ReadLine();
// int length=text.Length;
// if (length == 3)
// {
// char ch = text[2];
// Console.WriteLine($"Последняя цифра введенного числа - {ch}");
// }
// else
// {
//     Console.WriteLine("Введено НЕ трехзначное число!");
// }





// 10. Показать вторую цифру трёхзначного числа
// ПЕРВОЕ РЕШЕНИЕ
// int Test10(int arg)
// {
//     return (arg / 10) % 10;
// }

// int num = 356;
// Console.WriteLine(Test10(num));

// ВТОРОЕ РЕШЕНИЕ
// Console.Clear();

// Console.WriteLine("Введите трехзначное число");
// string text = Console.ReadLine();
// int length = text.Length;
// if (length == 3)
// {
//     char ch = text[1];
//     Console.WriteLine($"Вторая цифра введенного числа - {ch}");
// }
// else
// {
//     Console.WriteLine("Введено НЕ трехзначное число!");
// }





// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// bool Test11(int arg1, int arg2)
// {
//     return arg1 > arg2;
// }

// int num = new Random().Next(9, 100);
// Console.Clear();
// Console.WriteLine($"Случайное число из диапазона [10, 99]: {num}");
// int arg1 = num % 10;
// int arg2 = num / 10;

// if (Test11(arg1, arg2)) Console.WriteLine($"Наибольшее: {arg1}");
// else Console.WriteLine($"Наибольшее: {arg2}");






// 12. Удалить вторую цифру трёхзначного числа

// int Test12(int arg)
// {
//     return 10 * (arg / 100) + arg % 10;
// }

// int num = new Random().Next(99, 1000);
// Console.Clear();
// Console.WriteLine($"Случайное число из диапазона [100, 999]: {num}");
// Console.WriteLine($"Удаляем вторую цифру: {Test12(num)}");






// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// bool Test13(int arg1, int arg2)
// {
//     return arg1 % arg2 == 0;
// }

// int num1 = new Random().Next(99, 1000);
// int num2 = 10; //new Random().Next(0, 100);
// Console.Clear();
// Console.WriteLine($"Проверка, кратно ли {num2}-и число {num1}");

// if (Test13(num1, num2)==0) Console.WriteLine("Кратно");
// else Console.WriteLine($"Не кратно, остаток: {Test13(num1, num2)}");


// bool Multiple (int x, int x1)
// {
//         return x % x1 == 0;
// }

// int x = 47;
// int x1= 15;
// Multiple(x, x1);

// if (Multiple(x, x1)) Console.WriteLine($"Число кратно заданному");
// else Console.WriteLine($"Число не кратно заданному");



// 14. Найти третью цифру числа или сообщить, что её нет

// bool Test14(int arg)
// {
//     return arg / 100 < 1;
// }

// int num = new Random().Next(-1000000, 1000000);
// Console.Clear();
// Console.WriteLine($"Проверка, есть ли третья цифра (разряд сотен) в числе {num}");
// num = Math.Abs(num)/100;

// if (Test14(num)) Console.WriteLine("Нет");
// else Console.WriteLine($"Есть: {(num % 10)}");





// ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ

//метод (процедура) ожидание пользователя, для того, чтобы дать прочитать условие
void WaitUser()
{
    Console.WriteLine("Нажмите ENTER, когда будете готовы продолжить");
    while (true)
    {                                                       //цикл повторяется до тех пор, пока
        if (Convert.ToString(Console.ReadLine()) == "")     //не нажата клавиша Enter
        {
            break;                                          //по выполнению условия прерываю цикл
        }
    }
}




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




//Метод ожидающий ввода целочисленного числа, осуществляющий проверку ввода
int UserInteger()
{
    int integerNumber = 0; //переменная integerNumber, в данном случае, хранит число, которое ввел пользователь
    while (true)
    {
        Console.WriteLine("Введите целочисленное значение");
        if (int.TryParse((Console.ReadLine()), out int number)) //извлекаем из строки ввода символы и пытаемся присвоить им вещественный тип числа
        {
            integerNumber = number;  //если получилось, запоминаем число
            Console.Clear();
            break;          //очищаем экран и выходим из цикла
        }
        else
        {
            Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); //если не получилось, запрашиваем по новой
        }
    }
    return integerNumber;        // возвращаем значение метода (функции) в программу
}




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




















// Почувствуй себя джуном
//------------------------
// 15. Дано число. Проверить кратно ли оно 7 и 23
// bool Check15(int arg, int arg1)
// {
//     return arg % arg1 == 0;
// }

// int num = 46;
// if (Check15(num, 7)) Console.WriteLine($"Число {num} кратно 7");
// else Console.WriteLine($"Число {num} не кратно 7");
// if (Check15(num, 23)) Console.WriteLine($"Число {num} кратно 23");
// else Console.WriteLine($"Число {num} не кратно 23");






// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём
// bool Day(int arg)
// {
//     return arg < 6;
// }
// int day=6;
// if (Day(day)) Console.WriteLine("Рабочий день");
// else Console.WriteLine("Выходной день");





// 17. По двум заданным числам проверять является ли одно квадратом другого
// bool Test17(int arg1, int arg2)
// {
//     return arg1 == squareNumber(arg2);// возвращается логическое значение true или false
// }

// int arg1=8;
// int arg2=2;
// if (Test17(arg1, arg2)) Console.WriteLine("Первое число является квадратом второго");
// else Console.WriteLine("Первое число не является квадратом второго");




// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// x  y 
// f  f
// f  t
// t  f
// t  t

// bool 
// x = false , y = false;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = false; y = true;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = true; y = false;
// Console.WriteLine(!(x || y) == (!x && !y));
// x = true; y = true;
// Console.WriteLine(!(x || y) == (!x && !y));

bool f(bool arg1, bool arg2)
{
    return !(arg1 || arg2) == (!arg1 && !arg2);
}

// bool 
// x = false , y = false;
// Console.WriteLine(f(x, y));
// x = false; y = true;
// Console.WriteLine(f(x, y));
// x = true; y = false;
// Console.WriteLine(f(x, y));
// x = true; y = true;
// Console.WriteLine(f(x, y));

// bool 
// x = false , y = false;
// bool res = f(x, y);

// x = false; y = true;
// res =res && f(x, y);
// x = true; y = false;
// res =res && f(x, y);
// x = true; y = true;
// res =res && f(x, y);
// System.Console.WriteLine(res);

bool ConvertIntToBool(int arg)
{
    return arg == 1;
}
// bool res = true;
// for (int i = 0; i <= 1; i++)
// {
//     for (int j = 0; j <= 1; j++)
//     {
//         res = res && f(ConvertIntToBool(i), ConvertIntToBool(j));
//     }
// }
//System.Console.WriteLine(res);

bool Table()
{
    bool res = true;
    for (int i = 0; i <= 1; i++)
    {
        for (int j = 0; j <= 1; j++)
        {
            res = res && f(Convert.ToBoolean(i), ConvertIntToBool(j));
        }
    }
    return res;
}

// Console.WriteLine(Table());





// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// int Quarter(int x, int y)
// {
//     int quarter = 0;
//     if (x > 0 && y > 0) quarter = 1;
//     if (x > 0 && y < 0) quarter = 2;
//     if (x < 0 && y < 0) quarter = 3;
//     if (x < 0 && y > 0) quarter = 4;
//     return quarter;
// }

// int x = 1;
// int y = -2;
// Console.Clear();
// Console.WriteLine($"Числа {x} и {y} принадлежат к {Quarter(x, y)}-й четверти");




// 20. Ввести номер четверти, показать диапазоны для возможных координат
(string, string) Limits(int arg)
{
    var t = ("", "");
    if (arg == 1) t = ("X принадлежит диапазону вещественных чисел от 0 до + бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до + бесконечности");
    if (arg == 2) t = ("X принадлежит диапазону вещественных чисел от 0 до + бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до - бесконечности");
    if (arg == 3) t = ("X принадлежит диапазону вещественных чисел от 0 до - бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до - бесконечности");
    if (arg == 4) t = ("X принадлежит диапазону вещественных чисел от 0 до - бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до + бесконечности");
    return t;
}

int number;
while (true)
{
    Console.WriteLine("Enter the Quarter number");
    if (int.TryParse((Console.ReadLine()), out int num))
    {
        if (num > 0 && num <= 4)
        {
            number = num;
            break;
        }
    }
    else
    {
        Console.WriteLine("Enter the Quarter number");
    }
}
Console.WriteLine(Limits(number));

// (double, int) t1 = (4.5, 3);
// Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
// Console.WriteLine(t1.ToString());

// var t = 
// (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
// 11, 12, 13, 14, 15, 16, 17, 18,
// 19, 20, 21, 22, 23, 24, 25, 26);
// Console.WriteLine(t.Item26); 


// 21. Программа проверяет пятизначное число на палиндромом.
// bool Palindrom(int arg)
// {
//     bool result = false;
//     int i = 0;
//     int j = 5;
//     int[] mass = { 0, 0, 0, 0, 0 };
//     for (i = 4; i >= 0; i--)
//     {
//         if (arg < 10) mass[i] = arg;
//         else mass[i] = arg % 10;
//         arg = arg / 10;
//     }

//     for (i = 0; i <= 2; i++)
//     {
//         j = j - 1;
//         if (mass[i] != mass[j])
//         {
//             result = false;
//             i = 2;
//             break;
//         }
//         else result = true;
//     }
//     return result;
// }
// int num = 12361;
// if (Palindrom(num)) Console.WriteLine("Палиндром");
// else Console.WriteLine("Не палиндром");


// 22. Найти расстояние между точками в пространстве 2D/3D





// Почувствуй себя мидлом
//------------------------
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// Почувствуй себя сеньором
//--------------------------
// 31. Задать массив из 8 элементов и вывести их на экран 

// string PrintArray(int[] Array)
// {
//     string x = string.Empty;
//     for(int i = 0; i < 8; i++)
//     {
//         x += $"{Array[i]} ";
//     }
//     return x;
// }
// int[] Array = {1, 4, 5, 3, 5, 7, 9, 3};
// Console.WriteLine(PrintArray(Array));

// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

// int [] CreateArray(int arg, int arg1, int arg2)
//     {
//         int [] array = new int [arg];
//         for( int i = 0; i <array.Length; i++) array[i] = new Random().Next(arg1,arg2);
//         return array;
//     }

// Console.WriteLine(PrintArray(CreateArray(50, 0, 10)));


// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int Summ(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++) sum += Array[i]; //sum = sum + Arrai[i]
    return sum;
}

// Console.WriteLine(Summ(CreateArray(12, 0, 9)));

// 34. Написать программу замену элементов массива на противоположные

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


// int [] CreateArray(int arg, int arg1, int arg2)
//     {
//         int [] array = new int [arg];
//         for( int i = 0; i <array.Length; i++) array[i] = new Random().Next(arg1,arg2);
//         PrintIntArray(array);
//         return array;
//     }


// int[] Change(int[] arg)
// {
//     int[] mas = new int [arg.Length]; 
//     for( int i = 0; i <arg.Length; i++) mas[i] = arg[i] * -1;
//     return mas;
// }
// PrintIntArray(Change(CreateArray(10, -10, 10)));

// 35. Определить, присутствует ли в заданном массиве, некоторое число 

void PrintIntArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }

    Console.WriteLine();
}


int[] CreateArray(int arg, int arg1, int arg2)
{
    int[] array = new int[arg];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(arg1, arg2);
    PrintIntArray(array);
    return array;
}

bool FindNumber(int num, int[] array)
{

    int j = 0;
    while (j < array.Length)
    {
        if (array[j] == num)
        {
            Console.WriteLine(array[j]);
            break;
        }
    }
    return num == array[j];
}


// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// Почувствуй себя лидом
//--------------------------
// 41. Выяснить являются ли три числа сторонами треугольника 
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива
