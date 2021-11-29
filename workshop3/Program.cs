int[] Mixing(int numCards, int numDecks)
{
    int j, temp, fromValueCard; int count = 0; int[] deck = new int[numCards * numDecks];

    if (numCards == 52) fromValueCard = 2; else fromValueCard = 6;

    for (int k = 0; k < 4 * numDecks; k++)
    { for (int n = fromValueCard; n < 15; n++) { deck[count] = n; count += 1; } }

    for (int i = 0; i < deck.Length; i++)
    { temp = deck[i]; j = new Random().Next(i, deck.Length); deck[i] = deck[j]; deck[j] = temp; }

    return deck;
}

int RequestNumber(string words) // ввод чисел с проверкой
{
    while (true)
    {
        Console.Write(words);
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (num > 0) return num;
            else Console.WriteLine("Вы ввели значение меньше нуля, попробуйте еще разок!");
        }
        else Console.WriteLine("Что-то вы не то ввели, давайте-ка снова.");
    }
}

(string[] playersNames, int numDecks, int[] balance) Greetings()
{
    Console.Write("Введите имена игроков через запятую: ");
    string[] playersNames = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); //Прошлый код давал ошибку вводя строку "Маша, Паша, Саша", получали массив {"Маша","","Паша","","Cаша"}. Теперь можно вводить как "Маша Паша Саша" так и "Маша, Паша,Саша" и т.п.
    int[] balance = new int[playersNames.Length];
    int numDecks = RequestNumber("Укажите начальный баланс игроков: ");
    for (int i = 0; i < balance.Length; i++)
    {
        balance[i] = numDecks;
    }
    numDecks = RequestNumber("Сколько колод возьмём: ");
    return (playersNames, numDecks, balance);
}

int[] MakeBets(string[] playersNames, int[] balance) //опрос всех игроков о их ставке, количество игроков и их балансов должны быть массивы одинакового размера
{
    int playersCount = playersNames.Length;
    int[] betsArray = new int[playersCount];
    for (int i = 0; i < playersCount; i++)
    {
        betsArray[i] = AskForBet(playersNames[i], balance[i]);
    }
    return betsArray;
}

int AskForBet(string playerName, int playerBalance) //метод опроса отдельного игрока, переспрашивает пока ставка не будет больше 0 и меньше баланса.
{
    while (true)
    {
        int betAmount = RequestNumber($"{playerName} у вас {playerBalance} фишек, делайте вашу ставку: ");
        if (betAmount <= playerBalance) return betAmount;
        else Console.WriteLine($"Ставка не может быть меньше 1 или больше количества ваших фишек.");
    }
}

(int[,], int[]) SetUp(string[] playersNames, int[] deck) // создает двумерный массив, в котором каждая строка - массив карт игроков, столбец - значение карты
{
    int playersCount = playersNames.Length, deckCount = deck.Length - 1;
    int[,] playersDecks = new int[playersCount, 11]; // массивы колод игроков и крупье, максимальный размер - 11, 
    int[] croupierDeck = new int[11]; // исходя их худшей вариации минимальных карт: 1+1+1+1+2+2+2+2+3+3+3=21
                                      
    for (int i = 0; i < playersCount; i++) // первые две карты игроков
    {
        for (int j = 0; j < 2; j++)
        {
            if (deck[deckCount] == 0) { j--; deckCount--; } // проверка - если при втором раунде используем ту же колоду
            else { playersDecks[i, j] = deck[deckCount]; deck[deckCount] = 0; deckCount--; }
        }
    }

    for (int i = 0; i < 2; i++) // первые две карты крупье
    {
        if (deck[deckCount] == 0) { i--; deckCount--; }
        else { croupierDeck[i] = deck[deckCount]; deck[deckCount] = 0; deckCount--; }
    }
    return (playersDecks, croupierDeck);
}
//Код игры
void RunGame()
{
    (string[] playersNames, int numDecks, int[] balance) = Greetings(); //передаём результат кортежа в переменные
    int[] bets = MakeBets(playersNames, balance); //заполняем массив принятых ставок
    int[] deck = Mixing(52, numDecks);
    (int[,] playersDecks, int[] croupierDeck) = SetUp(playersNames, deck);
}

RunGame(); //запускаем игру
           // Console.WriteLine(String.Join(',', croupierDeck));