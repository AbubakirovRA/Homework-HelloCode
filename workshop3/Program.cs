// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно
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
}

int[,] RowToColumn(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        { int temp = mass[i, j]; mass[i, j] = mass[j, i]; mass[j, i] = temp; }
    }
    Console.WriteLine("Транспонированный массив:");
    return mass;
}
Console.Clear();
int[,] Array = getArray(5, 5); PrintArray(Array);

if (Array.GetLength(0) != Array.GetLength(1)) Console.WriteLine("Невозможно транспонировать");
else PrintArray(RowToColumn(Array));




// void Myxlezh(int n)// с интернетов
// {
//     Random r = new Random();
//     int[,] matrix = new int[n,n];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++) Console.Write("{0,4}", matrix[i, j] = r.Next(0, 100));
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < n; j++) Console.Write("{0,4}", matrix[j, i]);
//         Console.WriteLine();
//     }
//     Console.ReadKey(true);
// }

// Myxlezh(5);