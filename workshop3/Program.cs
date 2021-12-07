// 69. Найти сумму элементов от M до N, N и M заданы

int Sum(int n, int m)
{
    if (m == n) return m;
    else return m + Sum(n, m - 1);
}

Console.WriteLine(Sum(-1, 10));



