// The task about two friends and their dog from lesson #1 of course "Intro in Programming"

double first_friend_speed;
double second_friend_speed;
double dog_speed;
double distance;
double distance_min;
string user_answer;
int x, y;
user_answer = "";
x = 15;
y = 10;

Console.Clear();
Console.SetCursorPosition(x, y);
Console.WriteLine("Условие задачи:");
Console.WriteLine("Два друга находятся на каком-то расстоянии друг от друга и идут навстречу по дороге");
Console.WriteLine("В момент начала движения, от первого друга ко второму выбегает собака,");
Console.WriteLine("Достигнув второго друга собака разворачивается и бежит обратно, к первому другу");
Console.WriteLine("Собака бегает между ними до тех пор, пока они не встретятся.");
Console.WriteLine("Требуется вычислить сколько раз собака сбегает от одного друга к другому до момента их встречи.");
Console.WriteLine("Нажмите ENTER, когда будете готовы продолжить");

while (true)  
{
    if (Convert.ToString(Console.ReadLine()) == "")
        {
            break;
        }

}

Console.Clear();
Console.SetCursorPosition(x, y);
Console.WriteLine("Начнем ввод данных (Y/N)?");
user_answer = Console.ReadLine();
Console.Clear();
Console.SetCursorPosition(x, y);

while(user_answer.ToLower() == "y")
{
    while (true)
    {         
        Console.WriteLine("Введите скорость движения первого друга (м/сек)");
        if (double.TryParse((Console.ReadLine()), out double number))
                {
                    first_friend_speed = number;
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    break;
                }
        else 
                {
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
    }

    while (true)
    {
        Console.WriteLine("Введите скорость движения второго друга (м/сек)");
        if (double.TryParse((Console.ReadLine()), out double number))
                {
                    second_friend_speed = number;
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    break;
                }
        else 
                {
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
    }

    while (true)
    {
        Console.WriteLine("Введите скорость движения их собаки (м/сек)");
        if (double.TryParse((Console.ReadLine()), out double number))
                {
                    dog_speed = number;
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    break;
                }
        else 
                {
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
    }

    while (true)
    {
        Console.WriteLine("Введите расстояние между друзьями в начале движения (м)");
        if (double.TryParse((Console.ReadLine()), out double number))
                {
                    distance = number;
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    break;
                }
        else 
                {
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
    }                                

    while (true)
    {
        Console.WriteLine("Введите расстояние между друзьями при их встрече (м)");
        if (double.TryParse((Console.ReadLine()), out double number))
                {
                    distance_min = number;
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    break;
                }
        else 
                {
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
    }

    int count = 0;

    while (distance > distance_min)
        {
            if (count % 2 != 0)
            {
                distance = distance - (first_friend_speed + second_friend_speed) * (distance / (first_friend_speed + dog_speed));
            }

            else
            {
                distance = distance - (first_friend_speed + second_friend_speed) * (distance / (second_friend_speed + dog_speed));
            }

            count++;
        }

        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine($"Ответ: собака сбегала от одного друга ко второму  {count} раз");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
Console.WriteLine("Продолжить (Y/N)?");
user_answer = Console.ReadLine();
Console.Clear();
Console.SetCursorPosition(x, y);
}

Console.WriteLine("Завершаю работу");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();