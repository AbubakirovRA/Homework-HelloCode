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

    while (true)
    {
        Console.WriteLine("Введите скорость движения первого друга (м/сек)");
        if (double.TryParse((Console.ReadLine()), out double first_friend_speed)) 
            while (true)
            {
                Console.WriteLine("Введите скорость движения второго друга (м/сек)");
                if (double.TryParse((Console.ReadLine()), out double second_friend_speed))
                    while (true)
                    {
                        Console.WriteLine("Введите скорость движения их собаки (м/сек)");
                        if (double.TryParse((Console.ReadLine()), out double dog_speed))
                            while (true)
                            {
                                Console.WriteLine("Введите расстояние между друзьями в начале движения (м)");
                                if (double.TryParse((Console.ReadLine()), out double distance))
                                    while (true)
                                    {
                                        Console.WriteLine("Введите расстояние между друзьями при их встрече (м)");
                                        if (double.TryParse((Console.ReadLine()), out double distance_min))

                                        {
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

                                            Console.WriteLine($"Ответ: собака сбегала от одного друга ко второму  {count} раз");
                                            
                                        }
                                        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                                        
                                    }
                                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                                
                            }
                        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                        
                    }
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                
            }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
       
    }

}

else
{
    Console.WriteLine("Завершаю работу.");
}