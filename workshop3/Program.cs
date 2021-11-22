// 46. Написать программу масштабирования фигуры
int n = 2;
int k = 5;
int i = 0;
int j = 0;
Console.Clear();
for (i = 0; i < n * k; i++)
{
    for (j = 0; j < n * k; j++)
    {
        Console.SetCursorPosition(i, j);
        Console.Write("0");
    }

}

