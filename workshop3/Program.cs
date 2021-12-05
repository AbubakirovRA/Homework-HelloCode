// 50. В двумерном массиве n×k заменить четные элементы на противоположные
int[,] Main(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j]=new Random().Next(10, 100); 
            if (array[i,j]%2==0) array[i,j]=array[i,j]*-1;
            Console.Write($"{array[i,j]} ");
        }
    
        Console.WriteLine();
    }
    return array;
}

Main(5,5);