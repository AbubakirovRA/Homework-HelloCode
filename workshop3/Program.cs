// 48/ Показать двумерный массив размером m×n заполненный целыми числами
int[,] Main(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j]=new Random().Next(10, 100);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

Main(5,5);