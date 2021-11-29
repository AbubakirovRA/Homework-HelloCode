// int[] Mixing() // Перетасовка колоды карт, метод возвращает массив с 52-мя значениями карт,
// {              // размещенных на случайных позициях 
//     int[] deck = new int[52];
//     for (int i = 0; i < deck.Length; i++)
//     {
//         deck[i] = new Random().Next(1, 14);
//         if (CheckNum(deck[i], deck)) i -= 1;
//     }

//     bool CheckNum(int arg, int[] deck)
//     {
//         int count = 0;
//         for (int i = 0; i < deck.Length; i++) if (arg == deck[i]) count += 1;
//         return count > 4;
//     }
//     return deck;
// }







// (int[], int[]) setUp(int[] deck)            // набор карт игроком и крупье
// {                                           // метод возвращает два массива со значениями карт
//     int[] player = new int[deck.Length];    // массив игрока
//     int[] croupier = new int[deck.Length];  // массив крупье
//     int flag = 0;                           // переменная flag хранит позицию в массиве колоды
     
     
     
     
     
     
    
//                                             // на которой закончил брать карты игрок
//     player[0] = deck[deck.Length - 1];      // на первую (нулевую) позицию массива игрока записываем значение карты, которая находится в колоде на последней позиции
//     deck[deck.Length - 1] = 0;              // последнюю позицию массива колоды обнуляем

//     Console.WriteLine($"Ваша первая карта: {WhatIsCard(player[0])}");
//     if ((!Overload(player)) && player[0] == 1) player[0] = 111;

//     for (int i = 1; i < deck.Length - 1; i++)
//     {
//         Console.WriteLine("Ещё? (Да - 'Y', Нет - любая клавиша): ");
//         if (WaitUser())
//         {
//             player[i] = deck[deck.Length - 1 - i];
//             deck[deck.Length - 1 - i] = 0;
//             Console.WriteLine($"Ваша {i + 1}-я карта: {WhatIsCard(player[i])}");

//             if ((!Overload(player)) && player[i] == 1) player[i] = 111;
//             if (Overload(player))
//             {
//                 Console.WriteLine("У Вас перебор!");
//                 flag = i+1;
//                 i = deck.Length - 1;
//             }

//         }
//         else
//         {
//             flag = i;
//             i = deck.Length - 1;
//         }
//     }








//     croupier[0] = deck[deck.Length - flag-1];   // на первую позицию массива крупье (за минусом нулевых позиций, которые забрал игрок)
//                                                 // записываем значение карты, которая находится в колоде на последней позиции
//     deck[deck.Length - flag-1] = 0;             // последнюю позицию массива колоды ( за минусом нулевых) обнуляем

//     Thread.Sleep(1500);                         // задержка                         
//     Console.Clear();
//     Console.WriteLine($"Первый ход крупье. Выпала карта: {WhatIsCard(croupier[0])}");
//     if (croupier[0] == 1) croupier[0] = 111;    //если выпал туз, записываем в массив 111

//     for (int j = 1; j < deck.Length - 1; j++)
//     {
//         if (OverloadCroupier(croupier) < 17)
//         {
//             Thread.Sleep(1500);
//             Console.WriteLine($"{j + 1}-й xод крупье.");
//             croupier[j] = deck[deck.Length - (flag + 1) - j];
//             deck[deck.Length - (flag + 1) - j] = 0;
//             Console.WriteLine($"Выпала карта: {WhatIsCard(croupier[j])}");

//             if (croupier[j] == 1) croupier[j] = 111;
//             if (OverloadCroupier(croupier) > 21)
//             {
//                 Console.WriteLine("У крупье перебор!");
//                 j = deck.Length - 1;
//             }

//         }
//         else
//         {
//             j = deck.Length - 1;
//         }
//         Thread.Sleep(1500);
//     }








//     bool Overload(int[] collection)      // проверка "перебора" у игрока
//     {
//         int sum = 0;
//         for (int i = 0; i < collection.Length; i++)
//         {
//             if (collection[i] < 11) sum += collection[i];
//             else if (collection[i] == 111) sum += collection[i] - 100;
//             else sum += 10;
//         }
//         return sum > 21;
//     }




//     int OverloadCroupier(int[] collection)      // проверка "перебора" у крупье
//     {
//         int sum = 0;
//         for (int i = 0; i < collection.Length; i++)
//         {
//             if (collection[i] < 11) sum += collection[i];
//             else if (collection[i] == 111) sum += collection[i] - 100;
//             else sum += 10;
//         }
//         return sum;
//     }





//     bool WaitUser()                             //метод (процедура) ожидание ответа пользователя
//     {
//             string answer = Console.ReadLine();
//             return answer.ToLower() == "y";     //если нажата "y", то возвращает значение true
//     }




//     string WhatIsCard(int arg)
//     {
//         string ValueCard = string.Empty;
//         if (arg == 1) ValueCard = "Туз";
//         if (arg == 2) ValueCard = "Двойка";
//         if (arg == 3) ValueCard = "Тройка";
//         if (arg == 4) ValueCard = "Четверка";
//         if (arg == 5) ValueCard = "Пятерка";
//         if (arg == 6) ValueCard = "Шестерка";
//         if (arg == 7) ValueCard = "Семерка";
//         if (arg == 8) ValueCard = "Восьмерка";
//         if (arg == 9) ValueCard = "Девятка";
//         if (arg == 10) ValueCard = "Десятка";
//         if (arg == 11) ValueCard = "Валет";
//         if (arg == 12) ValueCard = "Дама";
//         if (arg == 13) ValueCard = "Король";
//         return ValueCard;
//     }




//     return (player, croupier);
// }










// Console.Clear();
// var score = setUp(Mixing());
// int playerScore = 0;
// int croupierScore = 0;

// for (int i = 0; i < score.Item1.Length; i++)
// {
//     if (score.Item1[i] < 11) playerScore += score.Item1[i];
//     else if (score.Item1[i] == 111) playerScore += score.Item1[i] - 100;
//     else playerScore += 10;
//     if (score.Item2[i] < 11) croupierScore += score.Item2[i];
//     else if (score.Item2[i] == 111) croupierScore += score.Item2[i]-100;
//     else croupierScore += 10;
// }
// Console.Clear();
// Console.WriteLine($"Счет игрока: {playerScore}, счет крупье: {croupierScore} ");
// // // Console.WriteLine(String.Join(',', array(10, -10, 10)));

// // int Cubic(int arg) {return arg*arg*arg;}
// // bool Even(int arg) {return arg%2==0;}
// // int n = 19;
// // for (int i=1; i<n; i++) {if (Even(Cubic(i))) Console.WriteLine((Cubic(i)));}

string[] deck = new string[52]; //Стартовая инициализация массива для колоды
int cash = 1000; //Стартовый запас денег
//string[] KeyForPlay = new string[] { "добрать", "взять", "стоп", "еще", "пас" };
string[] KeyForPull = new string[] { "еще", "взять", "добрать" }; //Фразы для того, что вытянуть карту
string[] KeyForStop = new string[] { "пас", "стоп", "хватит" }; //Фразы, чтобы остановиться

string[] ArraySum(string[] arr1, string[] arr2) //объединяет два массива в 1
{
    return arr1.Concat(arr2).ToArray();
}

void PrintArray(string[] arr)//печать массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
}

void ShuffleDeck()//Заполняет и перемешивает колоду
{
    string[] deck1 = new string[52]{  "2 of Spades", "2 of Clubs", "2 of Hearts", "2 of Diamonds",
                "3 of Spades", "3 of Clubs", "3 of Hearts", "3 of Diamonds",
                "4 of Spades", "4 of Clubs", "4 of Hearts", "4 of Diamonds",
                "5 of Spades", "5 of Clubs", "5 of Hearts", "5 of Diamonds",
                "6 of Spades", "6 of Clubs", "6 of Hearts", "6 of Diamonds",
                "7 of Spades", "7 of Clubs", "7 of Hearts", "7 of Diamonds",
                "8 of Spades", "8 of Clubs", "8 of Hearts", "8 of Diamonds",
                "9 of Spades", "9 of Clubs", "9 of Hearts", "9 of Diamonds",
                "10 of Spades", "10 of Clubs", "10 of Hearts", "10 of Diamonds",
                "J of Spades", "J of Clubs", "J of Hearts", "J of Diamonds",
                "Q of Spades", "Q of Clubs", "Q of Hearts", "Q of Diamonds",
                "K of Spades", "K of Clubs", "K of Hearts", "K of Diamonds",
                "A of Spades", "A of Clubs", "A of Hearts", "A of Diamonds",

    };
    deck = new string[52];
    int randomizer = new Random().Next(0, 52);
    for (int i = 0; i < 52; i++)
    {
        while (deck1[randomizer] == "0")
        {
            randomizer = new Random().Next(0, 52);
        }
        deck[i] = deck1[randomizer];
        deck1[randomizer] = "0";
        randomizer = new Random().Next(0, 52);
    }
    //return deck;
}

string cardKeep() //Возвращает имя карты из колоды. Удаляет из колоды.
{
    string CardKeeped = deck[deck.Length - 1];
    Array.Resize(ref deck, deck.Length - 1);
    if (deck.Length == 0) ShuffleDeck();
    return CardKeeped;
}

void CountCash(int summ, bool b) //Меняет остаток денег, к которым либо прибавляется либо отнимается сумм в зависимости от bool
{
    if (b) cash += (summ);
    else cash -= summ;

}

string[] Hand(string[] array)//Добавляет в руку карту(увеличивает массив на один и кладёт в последнюю ячейку карту из колоды)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = cardKeep();
    return array;
}

int Score(string element)//считает, сколько очков принесла карт
{
    string workingNum = Convert.ToString(element[0]);
    int sumReturn = 0;
    if (int.TryParse(workingNum, out sumReturn) && (sumReturn != 1)) return sumReturn;//ВАЖНО число десять будет обозначаться единичкой
    if (workingNum == "A") return 1;
    return 10;
}

int Points(string[] array)//Передаем руку и считаем, сколько она получила очков
{
    int sum = 0;
    int numAces = 0;
    int scores = 0;
    for (int i = 0; i < array.Length; i++)
    {
        scores = Score(array[i]);
        if (scores != 1) sum += scores;
        else numAces++;
    }
    if (numAces == 0) return sum;
    sum += (numAces - 1);
    if (sum < 11) return (sum + 11);
    else return (sum + 1);
}

string PointsCompare(int dealer, int player) //выводит победителя
{
    if (player > 21) return "lose";
    if (dealer > 21) return "win";
    if (dealer == player) return "tie";
    if ((dealer > player)) return "lose";
    if (dealer < player) return "win";
    return "ошибка";



}

void PrintWinner(string resultOfDuel, int dealerPoint, int playerPoint, int bet) //Печать в консоль, подсчет очков
{
    if (resultOfDuel == "win")
    {
        Console.WriteLine($"Поздравляю, в победили набрав {playerPoint} против {dealerPoint}");
        Console.WriteLine($"Выигрыш составил {bet}");
        CountCash(bet, true);
    }
    if (resultOfDuel == "lose")
    {
        Console.WriteLine($"К сожалению вы проиграли, {playerPoint} против {dealerPoint}");
        Console.WriteLine($"Проигрыш составил {bet}");
        CountCash(bet, false);
    }
    if (resultOfDuel == "tie")
    {
        Console.WriteLine($"Ничья");
    }
    if (resultOfDuel == "blackjake")
    {
        Console.WriteLine($"Поздравляю, ЭТО BLACKJACK");
        Console.WriteLine($"Выигрыш составил {Convert.ToInt32(Convert.ToDouble(bet) * (1.5))}");
        CountCash(Convert.ToInt32(Convert.ToDouble(bet) * (1.5)), true);
    }
}

string[] dealerHanding(string[] dealer, string closeCard) //Диллер добирает , пока не будет 17 или более
{
    Array.Resize(ref dealer, dealer.Length + 1);
    dealer[dealer.Length - 1] = closeCard;
    int sum = Points(dealer);
    while (sum < 17)
    {
        dealer = Hand(dealer);
        sum = Points(dealer);
    }
    return dealer;
}

string requestString(string s, string[] KeyWords)//Даем на вход сообщение, которое хотим вывести, и набор слов, которые можем получить. Читаем то, что ввел пользователь
{
    Console.WriteLine(s);
    string? result = Console.ReadLine();
    while (!(Array.Exists(KeyWords, element => element == result.ToLower())))
    {
        Console.WriteLine();
        Console.WriteLine("Не могу распознать команду\nСписок доступных команд:");
        PrintArray(KeyWords);
        Console.WriteLine("Введите команду заново");
        result = Console.ReadLine();
    }
    return result;

}

void GameInit() //инициализация игры
{
    cash = 1000;
    ShuffleDeck();
}

void PrintGameRulls()//Выводим или не выводим правила
{
    Console.WriteLine("Добро пожаловать в игру BlackJack!!!\nДля вызова правил введите <ПРАВИЛА>\n(Для продолжения введите что угодно)");
    if (Console.ReadLine().ToLower() == "правила")
    {
        Console.WriteLine($"В этой игре будет использоваться колода из {deck.Length} карт. Вы играете против диллера.\nУ вас в наличии {cash} хренек.");
        Console.WriteLine("В начале хода вы делаете ставку. Диллер раздает вам 2 карты из колоды в открытую и себе 1 карту в открытую и 1 карту в закрытую.");
        Console.WriteLine($"Вы можете использовать команды\n1. <{String.Join(", ", KeyForStop)}> - тогда ход перейдет к диллеру.\n2. <{String.Join(", ", KeyForPull)}> - диллер выдаст вам дополнительную карту");
        Console.WriteLine("Ценность карт J, Q, K - 10 баллов. А - 1 или 11. Цифры - соотвественно цифрам");
        Console.WriteLine("Если Вы набрали меньшее очков, чем у диллера или набрали больше 21 очка - вы проигрываете");
        Console.WriteLine("В случае, если диллер набрал больше 21 или Вы набрали больше очков, чем у диллера, вы получаете вдвое больше чем поставили.\nУдачи!");

    }
}

int requestingNum(string s, int min, int max)//Выводим сообщение s и считываем число////ТРЕБУЕТ ОБНОВЛЕНИЯ
{
    // Console.WriteLine(s);
    // return int.Parse(Console.ReadLine());
    Console.WriteLine(s);
    string? messageFromUser = Console.ReadLine();
    int EnteredNumber = 0;
    while (!((int.TryParse(messageFromUser, out EnteredNumber) && (EnteredNumber > min && EnteredNumber <= max))))
    {
        if ((int.TryParse(messageFromUser, out EnteredNumber)))
        {
            Console.WriteLine($"Максимальная ставка {max}!\nПовторите ввод:");
            messageFromUser = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Ошибка!\nВведите число!");
            messageFromUser = Console.ReadLine();
        }
    }
    return EnteredNumber;
}

bool BJ(string[] player, string[] dealer, int bet)
{
    if (Points(player) == 21)
    {
        Console.WriteLine("У вас BlackJack!\nОчередь диллера");
        PrintArray(dealer);        
        PrintWinner("blackjake", Points(dealer), Points(player), bet);
        return true;
    }
    return false;
}

bool makeTurn()
{
    int betplayer = requestingNum($"Сделайте ставку(Вам доступно {cash} хренек)", 0, cash);
    string[] dealerHand = Hand(new string[0]);
    string dealerCloseCard = cardKeep();
    string[] playerHand = Hand(Hand(new string[0]));
    string answer = string.Empty;
    Console.WriteLine("Рука диллера:");
    PrintArray(dealerHand);
    Console.WriteLine("Ваша рука:");
    PrintArray(playerHand);
    dealerHand = dealerHanding(dealerHand, dealerCloseCard);

    if (!BJ(playerHand,dealerHand,betplayer))
    {


        while (!(Array.Exists(KeyForStop, element => element == answer.ToLower())) && (Points(playerHand) < 22))
        {
            answer = requestString("Ваши действия?", ArraySum(KeyForPull, KeyForStop));
            if (Array.Exists(KeyForPull, element => element == answer.ToLower()))
            {
                playerHand = Hand(playerHand);
                Console.WriteLine("Ваша рука:");
                PrintArray(playerHand);
            }
        }


        Console.WriteLine("Очередь диллера");
        PrintArray(dealerHand);
        string resultDuel = PointsCompare(Points(dealerHand), Points(playerHand));
        PrintWinner(resultDuel, Points(dealerHand), Points(playerHand), betplayer);
    }


    if (cash > 0)
    {
        answer = requestString("Следующий раунд?", new string[] { "да", "нет" });
        return answer == "да";
    }
    else
    {
        Console.WriteLine("Игра окончена.");
        return false;
    }
}

void gameStart()
{
    GameInit();
    PrintGameRulls();
    bool exitGame = true;
    do
    {
        exitGame = makeTurn();
    } while (exitGame);
    Console.WriteLine($"Ваш баланс {cash}\nДо свидания!");


}

// PrintGameRulls();
// ShuffleDeck();

gameStart();








//ТЕСТЫ

//string testingRequest = requestString("Берем или нет?", new string[]{"брать", "пас", "дабл"});

// for(int i = 0; i < 15; i++)
// {
// string[] dealerHandTest = Hand(new string[0]);
// dealerHandTest = dealerHand(dealerHandTest);
// PrintArray(dealerHandTest);
// Console.WriteLine();
// }

// Console.WriteLine(PointsCompare(22, 23));//lose
// Console.WriteLine(PointsCompare(22, 21));//win
// Console.WriteLine(PointsCompare(22, 19));//win
// Console.WriteLine(PointsCompare(21, 21));//tie
// Console.WriteLine(PointsCompare(20, 21));//blackjake
// Console.WriteLine(PointsCompare(19, 20));//win
// Console.WriteLine(PointsCompare(20,19));//lose
// Console.WriteLine(PointsCompare(13,13));//tie

// Console.WriteLine(Points(new string[]{"A", "10", "5"})); //16
// Console.WriteLine(Points(new string[]{"A", "A"})); //12
// Console.WriteLine(Points(new string[]{"A", "10"})); //21
// Console.WriteLine(Points(new string[]{"A", "A", "A"})); //13
// Console.WriteLine(Points(new string[]{"A", "A", "A", "A"})); //14
// Console.WriteLine(Points(new string[]{"A", "A", "10"})); //12
// Console.WriteLine(Points(new string[]{"A"})); //11





// PrintArray(deck);