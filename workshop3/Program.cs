// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно
int[,] getArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] RowToColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    Console.WriteLine("Транспонированный массив:");
    return array;
}
Console.Clear();
int[,] Array = getArray(5, 5);
PrintArray(Array);
if (Array.GetLength(0) != Array.GetLength(1)) Console.WriteLine("Невозможно транспонировать");
else PrintArray(RowToColumn(Array));
