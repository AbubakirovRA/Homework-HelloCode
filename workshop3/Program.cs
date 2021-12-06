
// 66. Показать натуральные числа от 1 до N, N задано (рекурсивной функцией)
// int Natural(int i, int n)
// {
//     if (n == 0) return 0;
//     else {Console.Write($"{i} ");
//     return Natural(i += 1, n - 1);}
// }

// Natural(1, 15);

// int Foo(int n) // второе решение
// {
//     if (n==0) return 1;
//     Console.Write("{0,4}", Foo(n-1));
//     return n+1;
// }
// Foo(10);
// System.Console.WriteLine();

int Main(string[] j, string[] s)
{
    int count = 0;
    for (int i = 0; i < j.Length; i++)
    {
        if (s[i] == j[i]) count += 1;
    }
    return count;
}
string j = Console.ReadLine();
string s = Console.ReadLine();

string[] J = j.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
string[] S = s.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(Main(J, S));
