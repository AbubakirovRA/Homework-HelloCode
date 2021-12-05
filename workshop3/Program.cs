// 51. Задать двумерный массив следующим правилом: A[m,n]=m+n
int[,] Main(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j]=i + j; 
            Console.Write($"{array[i,j]} ");
        }
    
        Console.WriteLine();
    }
    return array;
}

Main(5,5);