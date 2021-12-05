// 54. В матрице чисел найти сумму элементов главной диагонали
int Main(int m, int n)
{
    int sum=0; int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j]=new Random().Next(1, 10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    for (int i = 0; i < m; i++)
    {
        sum +=array[i,i];
    }
    return sum;
}
Console.Clear();
Console.WriteLine($"Сумма элементов главной диагонали равнf: {Main(5,5)}");