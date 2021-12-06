// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear(); int[,] Array = getArray(5, 5);
PrintArray(Array); Console.WriteLine($"MinValue = {findMin(Array)}");

int findMin(int[,] mass)
{
    int minValue = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            sum += mass[i, j];
        }
        if (i == 0) minValue = sum;
        if (minValue > sum) minValue = sum;
    }
    return minValue;
}

int[,] getArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        { array[i, j] = new Random().Next(1, 10); }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        { Console.Write("{0,4}", arr[i, j]); }
        Console.WriteLine();
    }
    Console.WriteLine();
}
