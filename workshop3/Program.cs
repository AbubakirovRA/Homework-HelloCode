// 68. Показать натуральные числа от M до N, N и M заданы

int Natural(int i, int n)
{
    if (n == i-1) return i;
    else {Console.Write("{0,4}", n);
    return  Natural(i, n-1);}
}

Natural(0, 25); Console.WriteLine();

