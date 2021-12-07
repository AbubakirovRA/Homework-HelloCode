// 70. Найти сумму цифр числа
int Sum(int n)
{ if (n < 10) return n; else return n % 10 + Sum(n / 10); }
Console.WriteLine(Sum(1000001));





