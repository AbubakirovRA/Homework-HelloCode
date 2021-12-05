// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
(int, int) Main((int m, int n, int userNum)data)
{
    int[,] array = getArray(data.m, data.n);
    for (int i = 0; i < data.m; i++)
    {
        for (int j = 0; j < data.n; j++)
        {
            if (array[i, j] == data.userNum) return (i, j);
        }
    }
    return (0, 0);
}

int[,] getArray(int m, int n)
{
    int[,] mass = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            mass[i, j] = new Random().Next(10, 100);
            Console.Write($"{mass[i,j]} ");
        }
    Console.WriteLine();
    }
    return mass;
}

Console.Clear();
var data = (5, 5, 31);
var result = Main(data);
if (result.Item1 == 0) Console.WriteLine($"Значение {data.Item3} в массиве отсутствует");
else Console.WriteLine($"Значение {data.Item3} является ({result.Item1}, {result.Item2})-й элементом массива ");

