// 60. Составить частотный словарь элементов двумерного массива

(int, int) FindNum(int[,] matrix, int arg)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (matrix[i, j] == arg) count++;
        }
    }
    return (arg, count);
}



void Foo(int[,] data)
{
    int max = 20; // максимальное значение в массиве data
    int[] elements = new int[max + 1];
    for (int i = 0; i < data.GetLength(0); i++)
    {
        for (int j = 0; j < data.GetLength(1); j++)
        {
            elements[data[i,j]]++;
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


void Foo(int[,] data)
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







Console.Clear(); int[,] Array = getArray(5, 5);
PrintArray(Array); 

int CheckNum(int[,] mass)
{
    int minValue = 0;
    for (int k=0; k<mass.GetLength(0)*mass.GetLength(1))
    {
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
    }
    return minValue;
}

int[,] getArray(int row, int col)
{
    Random r=new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        { array[i, j] = r.Next(1, 10); }
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
