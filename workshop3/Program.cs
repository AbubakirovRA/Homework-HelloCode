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