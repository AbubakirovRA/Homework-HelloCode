// 56. Написать программу, которая обменивает элементы первой строки и последней строки

Console.Clear(); int[,] Array = getArray(5, 5); 
PrintArray(Array); PrintArray(exchangeRow(Array));

int[,] exchangeRow(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(1); i++)
    {
        int temp = mass[0, i];
        mass[0, i] = mass[mass.GetLength(0) - 1, i];
        mass[mass.GetLength(0) - 1, i] = temp;
    }
    return mass;
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
