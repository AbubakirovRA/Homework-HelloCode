// 20. Ввести номер четверти, показать диапазоны для возможных координат
// (string, string) Limits(int arg)
// {
//     var t = ("", "");
//     if (arg == 1) t = ("X принадлежит диапазону вещественных чисел от 0 до + бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до + бесконечности");
//     if (arg == 2) t = ("X принадлежит диапазону вещественных чисел от 0 до + бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до - бесконечности");
//     if (arg == 3) t = ("X принадлежит диапазону вещественных чисел от 0 до - бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до - бесконечности");
//     if (arg == 4) t = ("X принадлежит диапазону вещественных чисел от 0 до - бесконечности", "Y принадлежит диапазону вещественных чисел от 0 до + бесконечности");
//     return t;
// }

// int number;
// while (true)
// {
//     Console.WriteLine("Enter the Quarter number");
//     if (int.TryParse((Console.ReadLine()), out int num))
//     {
//         if (num > 0 && num <= 4)
//         {
//             number = num;
//             break;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Enter the Quarter number");
//     }
// }
// Console.WriteLine(Limits(number));

// (double, int) t1 = (4.5, 3);
// Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
// Console.WriteLine(t1.ToString());

// var t = 
// (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
// 11, 12, 13, 14, 15, 16, 17, 18,
// 19, 20, 21, 22, 23, 24, 25, 26);
// Console.WriteLine(t.Item26); 