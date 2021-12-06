// 69. Найти сумму элементов от M до N, N и M заданы

int Natural(int i, int n)
{
    if (n == i-1) return n+i;
    else n +=(n-1);
    return  Natural(i, n-1);
}

Natural(0, 5); Console.WriteLine();

