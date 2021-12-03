// 57. Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива.
int[,] Sorting(int[,] array)
{
    for (int i = 0; i < array.GetLength(0);i++)
        {
            for (int j=0; j < array.GetLength(1); j++)
                {
                    
                }
        }
    return array;
}


// 66. Показать натуральные числа от 1 до N, N задано
// int Natural(int i, int n)
// {
//     if (n == 0) return 0;
//     else {Console.Write($"{i} ");
//     return Natural(i += 1, n - 1);}
// }

// Natural(1, 15);





int[,] Array(int m, int n) // метод создания массива
{
    int[,] Array = new int[m, n];
    return Array;
}

int[,] FillArray(int[,] Arr) // метод заполения массива 
{

    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLongLength(1); j++)
        {
            Arr[i, j] = (new Random().Next(0, 10));
        }
    }
    return Arr;
}

void PrintArray(int[,] Arr) // метод вывода массива в консоль
{

    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLongLength(1); j++)
        {
            Console.Write($" {Arr[i, j]}");
        }
        Console.WriteLine();
    }
}
