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

Console.WriteLine(String.Join(',', Mixing(36, 6)));