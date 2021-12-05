// 49 Показать двумерный массив размером m×n заполненный вещественными числами
double[,] Main(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j]=Math.Round((new Random().NextDouble()*10), 2); // Math.Round(double value, int digits) - округление
            Console.Write($"{array[i,j]} ");         //value - число, которое нужно округлить, digits - количество цифр в дробной части, которые нужно оставить.
        }
    
        Console.WriteLine();
    }
    return array;
}

Main(5,5);