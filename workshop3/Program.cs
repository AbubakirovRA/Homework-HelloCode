
// 66. Показать натуральные числа от 1 до N, N задано
int Natural(int i, int n)
{
    if (n == 0) return 0;
    else {Console.Write($"{i} ");
    return Natural(i += 1, n - 1);}
}

Natural(1, 15);

