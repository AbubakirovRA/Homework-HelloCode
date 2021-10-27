// The task about two friends and their dog from lesson #1 of course "Intro in Programming"
Console.Clear();

Console.WriteLine("Условие задачи:");
Console.WriteLine("Два друга находятся на каком-то расстоянии друг от друга и идут навстречу по дороге");
Console.WriteLine("В момент начала движения, от первого друга ко второму выбегает собака,");
Console.WriteLine("Достигнув второго друга собака разворачивается и бежит обратно, к первому другу");
Console.WriteLine("Собака бегает между ними до тех пор, пока они не встретятся.");
Console.WriteLine("Требуется вычислить сколько раз собака сбегает от одного друга к другому до момента их встречи.");

Console.Write("Готовы вводить данные? (y/n)");

string condition = Console.ReadLine();

if (condition.ToLower() == "y")
{
    Console.WriteLine("Здорово! Приступим.");

    Console.WriteLine("Введите скорость движения первого друга (м/сек)");
    string ff = Console.ReadLine();
    double first_friend_speed = Convert.ToDouble (ff);

    Console.WriteLine("Введите скорость движения второго друга (м/сек)");
    string sf = Console.ReadLine();
    double second_friend_speed = Convert.ToDouble (sf);

    Console.WriteLine("Введите скорость движения их собаки (м/сек)");
    string df = Console.ReadLine();
    double dog_speed = Convert.ToDouble (df);

    Console.WriteLine("Введите расстояние между друзьями в начале движения (м)");
    string s = Console.ReadLine();
    double distance = Convert.ToDouble (s);

    Console.WriteLine("Введите расстояние между друзьями при их встрече (м)");
    string s_min = Console.ReadLine();
    double distance_min = Convert.ToDouble (s_min);

double overall_speed_dog_first_friend = first_friend_speed + dog_speed;

double overall_speed_dog_second_friend = second_friend_speed + dog_speed;

double count = 0;

double time = 0;

while (distance > distance_min)
{
    if (count % 2 != 0)
    {
        distance = distance - (first_friend_speed + second_friend_speed) * (distance / overall_speed_dog_first_friend);
    }

    else
    {
        distance = distance - (first_friend_speed + second_friend_speed) * (distance / overall_speed_dog_second_friend);
    }

    count++;

}
Console.WriteLine($"Ответ: собака сбегала от одного друга ко второму  {count} раз");
}

else
{
    Console.WriteLine("Завершаю работу.");
}

