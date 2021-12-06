// 67. Показать натуральные числа от N до 1, N задано
int Foo(int n)
{
    if (n==0) return 1;
    Console.Write("{0,4}", n);
    return Foo(n-1);
}
Foo(20);
System.Console.WriteLine();

