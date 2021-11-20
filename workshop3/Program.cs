// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// Порядок действий:
//1. инверсия  ¬ ( Not)
// 2. конъюнкция  ⋀ (And)
// 3. дизъюнкция ⋁ ( Or)

// Количество логических переменных 2, следовательно, количество строк — 2 в степени 2 = 4
// Количество логических операций в формуле 5, количество логических переменных 2, 
// следовательно количество столбцов — 2 + 5 = 7

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

// bool f(bool arg1, bool arg2)
// {
//     return !(arg1 || arg2) == (!arg1 && !arg2);
// }

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

// bool ConvertIntToBool(int arg)
// {
//     return arg == 1;
// }
// bool res = true;
// for (int i = 0; i <= 1; i++)
// {
//     for (int j = 0; j <= 1; j++)
//     {
//         res = res && f(ConvertIntToBool(i), ConvertIntToBool(j));
//     }
// }
//System.Console.WriteLine(res);

// bool Table()
// {
//     bool res = true;
//     for (int i = 0; i <= 1; i++)
//     {
//         for (int j = 0; j <= 1; j++)
//         {
//             res = res && f(Convert.ToBoolean(i), ConvertIntToBool(j));
//         }
//     }
//     return res;
// }

// Console.WriteLine(Table());