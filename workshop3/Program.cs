int[] Mixing()
{
    int[] deck = new int[52];
    for (int i = 0; i < deck.Length; i++)
    {
        deck[i] = new Random().Next(1, 14);
        if (CheckNum(deck[i], deck)) i -= 1;
    }

    bool CheckNum(int arg, int[] deck)
    {
        int count = 0;
        for (int i = 0; i < deck.Length; i++) if (arg == deck[i]) count += 1;
        return count > 4;
    }
    return deck;
}


(int[], int[]) setUp(int[] deck)
{
    int[] player = new int[deck.Length];
    int[] croupier = new int[deck.Length];
    int flag = 0;

    player[0] = deck[deck.Length - 1];
    deck[deck.Length - 1] = 0;

    // Console.WriteLine(String.Join(',', deck));
    Console.WriteLine($"Ваша первая карта: {WhatIsCard(player[0])}");
    if ((!Overload(player)) && player[0] == 1) player[0] = 11;

    for (int i = 1; i < deck.Length - 1; i++)
    {
        Console.WriteLine("Ещё? (Да - 'Y', Нет - любая клавиша): ");
        if (WaitUser())
        {
            player[i] = deck[deck.Length - 1 - i];
            deck[deck.Length - 1 - i] = 0;
            Console.WriteLine($"Ваша {i + 1}-я карта: {WhatIsCard(player[i])}");
            // Console.WriteLine(String.Join(',', player));
            if ((!Overload(player)) && player[i] == 1) player[i] = 11;
            // Console.WriteLine(String.Join(',', player));
            if (Overload(player))
            {
                Console.WriteLine("У Вас перебор. Вы проиграли!");
                i = deck.Length - 1;
            }

        }
        else
        {
            flag = i;
            i = deck.Length - 1;
        }
    }

    croupier[0] = deck[deck.Length - flag - 1];
    deck[deck.Length - flag - 1] = 0;

    Thread.Sleep(1500);
    Console.Clear();

    // Console.WriteLine(String.Join(',', deck));
    Console.WriteLine($"Ход крупье. Первая карта крупье: {WhatIsCard(croupier[0])}");
    if (croupier[0] == 1) croupier[0] = 11;

    for (int j = 1; j < deck.Length - 1; j++)
    {
        if (OverloadCroupier(croupier) < 17)
        {
            Thread.Sleep(1500);
            Console.WriteLine($"{j + 1}-й xод крупье.");
            croupier[j] = deck[deck.Length - (flag + 1) - j];
            deck[deck.Length - (flag + 1) - j] = 0;
            Console.WriteLine($"{j + 1}-я карта крупье: {WhatIsCard(croupier[j])}");
            // Console.WriteLine(String.Join(',', croupier));
            if (croupier[j] == 1) croupier[j] = 11;
            // Console.WriteLine(String.Join(',', croupier));
            if (OverloadCroupier(croupier) > 21)
            {
                Console.WriteLine("У крупье перебор. Вы выиграли!");
                j = deck.Length - 1;
            }

        }
        else
        {
            j = deck.Length - 1;
        }
        Thread.Sleep(1500);
    }

    bool Overload(int[] collection)
    {
        int sum = 0;
        for (int i = 0; i < collection.Length; i++)
        {
            if (collection[i] < 11) sum += collection[i];
            else sum += 10;
        }
        return sum > 21;
    }

    int OverloadCroupier(int[] collection)
    {
        int sum = 0;
        for (int i = 0; i < collection.Length; i++)
        {
            if (collection[i] < 11) sum += collection[i];
            else sum += 10;
        }
        return sum;
    }

    bool WaitUser() //метод (процедура) ожидание ответа пользователя
    {
        while (true)
        {
            string answer = Console.ReadLine();
            return answer.ToLower() == "y";
        }
    }

    string WhatIsCard(int arg)
    {
        string ValueCard = string.Empty;
        if (arg == 1) ValueCard = "Туз";
        if (arg == 2) ValueCard = "Двойка";
        if (arg == 3) ValueCard = "Тройка";
        if (arg == 4) ValueCard = "Четверка";
        if (arg == 5) ValueCard = "Пятерка";
        if (arg == 6) ValueCard = "Шестерка";
        if (arg == 7) ValueCard = "Семерка";
        if (arg == 8) ValueCard = "Восьмерка";
        if (arg == 9) ValueCard = "Девятка";
        if (arg == 10) ValueCard = "Десятка";
        if (arg == 11) ValueCard = "Валет";
        if (arg == 12) ValueCard = "Дама";
        if (arg == 13) ValueCard = "Король";
        return ValueCard;
    }

    return (player, croupier);
}

Console.Clear();
var score = setUp(Mixing());
int playerScore = 0;
int croupierScore = 0;
// Console.WriteLine(String.Join(',', score.Item1));
// Console.WriteLine(String.Join(',', score.Item2));

for (int i=0; i<score.Item1.Length; i++)
{
    if (score.Item1[i] < 11) playerScore += score.Item1[i];
    else playerScore += 10;
    if (score.Item2[i] < 11) croupierScore += score.Item2[i];
    else croupierScore += 10;
}
Console.Clear();
Console.WriteLine($"Счет игрока: {playerScore}, счет крупье: {croupierScore} ");



// Объясняю в двух словах:
// Пишем

// List<int> col= new();

// Чтобы добавить элемент пишем
// col.Add(123);

// Чтобы удалить col.Remove(123);

// Узнать количество элементов : col.Count
// Работать можно как с массивом: col[1] = 28;
// int[] a=new int[]{1, 2, 3};
// int[] b=new int[]{4, 5, 6};
// int[] c=a.Concat(b).ToArray(); объединение массивов