(int secretNumber, int countOfAttempts, string namePlayer) = Welcome();
if (secretNumber == -99) Console.WriteLine("G A M E   O V E R!");
else
{
    Console.Clear();
    Console.WriteLine($"Ok, {namePlayer}, I guess a Number!");
}

int RequestNumber(string words) // input of numbers with validation 
{
    while (true)
    {
        Console.Write(words);
        if (int.TryParse(Console.ReadLine(), out int num) && num > 0) return num;
        else Console.WriteLine("You have entered something wrong, try one more.");
    }
}

bool userAnswer(string MessageValue) //waiting for user response 
{
    Console.WriteLine(MessageValue);
    string answer = Console.ReadLine();
    return answer.ToLower() == "y";     //if "y" is pressed, it returns true 
}
