// 60. Составить частотный словарь элементов двумерного массива

void Foo(int[,] data) // Решение от Сергея
{
    var maxMin = FindMaxMin(data);
    int max = maxMin.Item1;
    int min = maxMin.Item2;
    int[] elements = new int[max + Math.Abs(min) + 1];
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            elements[data[i,j] + Math.Abs(min)]++;
        }
    }

    for (int i = 0; i < elements.Length; i++)
    {
        if(elements[i]!=0) System.Console.WriteLine($"{i - Math.Abs(min)} - встречается {elements[i]}");
    }

}

(int, int) FindMaxMin(int[,] matrix)
{
    int max = 0;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (matrix[i,j] > max) max = matrix[i,j];
            if (matrix[i,j] < min) min = matrix[i,j];
        }
    }
    return (max, min);
}

Console.Clear(); int[,] Array = getArray(5, 5);
PrintArray(Array); Foo(Array);

int[,] getArray(int row, int col)
{
    Random r=new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        { array[i, j] = r.Next(-7, 10); }
    }
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        { Console.Write("{0,4}", arr[i, j]);}
        Console.WriteLine();
    }
    Console.WriteLine();
}

// string PrintArray(int[,] arr) // Решение 1
// {
//     string str=string.Empty;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         { Console.Write("{0,4}", arr[i, j]); str += $"{FindNum(arr, arr[i,j])}, "; }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return str;
// }

// (int, int) FindNum(int[,] matrix, int arg) // Решение 1
// {
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             if (matrix[i, j] == arg) count++;
//         }
//     }
//     return (arg, count);
// }