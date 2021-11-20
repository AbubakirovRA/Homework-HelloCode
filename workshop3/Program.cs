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