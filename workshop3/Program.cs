// 44. Найти точку пересечения двух прямых заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// (double, double) Cross((int k, int b) a1, (int k, int b) a2)
// {
//     double y = (a2.b * a1.k - a1.b * a2.k) / (a1.k - a2.k); //y выражен из y = k2 * x + b2 ч/з подстановку
//     double x = (y-a1.b)/a1.k;                              //в качестве x выражения (y-b1)/k1
//     // double x = (a2.b-a1.b)/(a1.k+a2.k); //альтернативная формула выведенная из приравнивания
//     // double y = (a1.k*x+a1.b);           //уравненний друг к другу, исзодя из предположения,
//     return (x, y);                      //что если прямые пересекаются значит и x у них одинаковый
// }
// var A1 = (12, 1); //коэффициенты k1 и b1
// var A2 = (6, 3); //коэффициенты k2 и b2
// Console.WriteLine($"Имеем две прямые: y = {A1.Item1}x + {A1.Item2} и y = {A2.Item1}x + {A2.Item2}");
// if (Convert.ToDouble(A1.Item1) / Convert.ToDouble(A2.Item1)==Convert.ToDouble(A1.Item2) / Convert.ToDouble(A2.Item2)) Console.WriteLine($"Прямые параллельны либо совпадают");
// else Console.WriteLine($"Точка пересечения прямых {(Cross(A1, A2))}");

// (double, double) CheckCross() //решение системы двух линейных уравнений по формулам Крамера
// {                                     //находится определитель системы Delta = a * b1 - b * a1, 
//     double a = Read("a");             //если он не равен 0, то система имеет единственное решение
//     double b = Read("b");             //далее находится Delta(x), тогда x= Delta(x) / Delta
//     double c = Read("c");             //аналогично находится Delta(y), тогда y= Delta(y) / Delta
//     double a1 = Read("a1");
//     double b1 = Read("b1");
//     double c1 = Read("c1");

//     double Delta = a * b1 - b * a1;   //определитель системы уравнений
//     if (Delta != 0) 
//     {
//         Console.WriteLine($"Система имеет единственное решение");
//         return ((a * c1 - c * a1 / Delta), (c * b1 - b * c1 / Delta));
//     }
//     else 
//     {
//         Console.WriteLine($"Cистема не имеет решений");
//         return ((a * c1 - c * a1 / Delta), (c * b1 - b * c1 / Delta));
//     }
// }

// double Read(string Name)
// {
//     Console.Write(Name + " = ");
//     return double.Parse(Console.ReadLine());
// }
// var res = CheckCross();
// Console.WriteLine($"x = {res.Item1}, y = {res.Item2}");
// Console.ReadKey();
