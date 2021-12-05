// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] Main(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(10, 100);
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = squareNumber(array[i, j]);
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
    return array;
}

int squareNumber(int arg)
{
    return (arg * arg);
}

Main(5, 5);