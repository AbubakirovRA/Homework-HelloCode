// 57. Написать программу упорядочивания по убыванию элементов каждой строки двумерного массива.
int[,] Sorting(int[,] array)
{
    PrintArray(array);
    System.Console.WriteLine();
    int j, temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            for (j = 0; j < array.GetLength(1) - 1; j++) // цикл сортировки по убыванию (по возрастанию изменить знак)
            {
                if (array[i, j] < (array[i, j + 1])) // сортировка выбором
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
            j += n;
        }
    }
    return array;
}
Console.Clear();
PrintArray(Sorting(FillArray(Array(6, 6))));

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
