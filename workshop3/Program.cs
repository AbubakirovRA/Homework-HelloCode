// 46. Написать программу масштабирования фигуры
// int n = 2;
// int k = 2;
// int i = 0;
// int j = 0;
// Console.Clear();
// for (i = 0; i < n * k; i++)
// {
//     for (j = 0; j < n * k; j++)
//     {
//         Console.SetCursorPosition(i, j);
//         Console.Write("0");
//     }

// }

// Дан набор точек, допустим прямоугольник.
// Имеем 4 координаты: x1,y1,   x2,y2,   x3,y3,   x4,y4;
// Коэффициент масштабирования k;

((int, int), (int, int), (int, int)) ScaleSquare(int scale, (int x, int y) a, (int x, int y) b)
{
    int deltaX = b.x - a.x;
    int deltaY = b.y - a.y;
    //Console.WriteLine($"{(a.x, a.y)}, {(b.x, b.y)}, {deltaX}, {deltaY}");
    for (int i = 1; i < scale; i++)
    {
        b.x = b.x + deltaX;
        b.y = b.y + deltaY;
    }
    //Console.WriteLine($"{(a.x, a.y)}, {(b.x, b.y)}");
    return ((a.x, b.y), (b.x, a.y), (b.x, b.y));
}

int Read(string Name)
{
    Console.Write(Name + " = ");
    return int.Parse(Console.ReadLine());
}

Console.Clear();
int x = Read("X for point A ");
int y = Read("Y for point A ");
int x1 = Read("X1 for point B ");
int y1 = Read("Y1 for point B ");
var a = (x, y);
var b = (x1, y1);

int scale = Read("Scale ");

Console.WriteLine($"Координаты вершин прямоугольника: {a}, {ScaleSquare(scale, a, b)}");