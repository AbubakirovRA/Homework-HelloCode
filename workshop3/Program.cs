// 30. Показать кубы чисел, заканчивающихся на четную цифру

// int Cubic(int arg)
// {
//     return (arg * arg * arg);
// }

// int n = 19;
// for (int i = 1; i <= n; i++)
// {
//     if (Cubic(i)%2==0) Console.WriteLine($"Cubic {i} = {Cubic(i)}");
// }

int Cubic(int arg) {return arg*arg*arg;}
bool Even(int arg) {return arg%2==0;}
int n = 5;
for (int i=1; i<n; i++) {if (Even(Cubic(i))) Console.WriteLine((Cubic(i)));}
