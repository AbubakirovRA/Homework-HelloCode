// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] getArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    return array;
}

int[] colAverage(int[,] array)
{
    int[] summ = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j=0; j<array.GetLength(0);j++)
        {
            summ[i] +=array[j,i];
        }
    }
    Console.WriteLine("Суммы столбцов массива:");
    return summ;
}
Console.Clear();
Console.WriteLine(String.Join(", ",(colAverage(getArray(5, 5)))));
