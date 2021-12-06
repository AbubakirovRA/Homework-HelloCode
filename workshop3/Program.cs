// 61. Найти произведение двух матриц

Console.Clear(); 
int[,] Array1 = getArray(4, 4);
int[,] Array2 = getArray(4, 4);
Console.WriteLine($" Матрица №1:"); PrintArray(Array1);
Console.WriteLine($" Матрица №2:"); PrintArray(Array2); 
Console.WriteLine($" Произведение матриц:"); 
if (Array1.GetLength(0)>Array2.GetLength(1) || Array2.GetLength(0)>Array2.GetLength(1)) 
Console.WriteLine("Данные матрицы перемножить нельзя");
else PrintArray(SumArray(Array1, Array2));


int[,] SumArray(int[,] arr1, int[,] arr2)
{
    int[,] arr3=new int[arr1.GetLength(0), arr2.GetLength(0)];
    for (int i=0; i<arr1.GetLength(0);i++)
    {
        for (int j=0; j<arr2.GetLength(0); j++)
        {
            for (int k=0; k<arr2.GetLength(0);k++)
                {arr3[i,j] += (arr1[i,k]*arr2[k,j]);}
        }
    }
    return arr3;
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
        { Console.Write("{0,4}", arr[i, j]);}
        Console.WriteLine();
    }
    Console.WriteLine();
}