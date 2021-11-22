// 45. Показать числа Фибоначчи
int F(int n)
{
    if (n == 1 || n == 2) return 1;
    else return F(n - 1) + F(n - 2);
}

for (int i = 1; i < 25; i++)
{
    Console.WriteLine(F(i));
}