using DiceRollGame;

int num = DiceRoller.RollDice();
int attempts = 3;

Console.WriteLine($"Dice rolled. Guess what number it shows in {attempts} tries:");
while (attempts > 0)
{
    Console.Write("Enter number: ");

    string guess = Console.ReadLine();
    if (GuessValidator.IsValid(guess))
    {
        int guessedNumber = int.Parse(guess);

        if (guessedNumber == num)
        {
            Console.WriteLine("You win");
            break;
        }

        attempts--;
        Console.WriteLine("Wrong number.");
    }
    else
    {
        Console.WriteLine("Incorrect input. No attempt lost.");
    }
}

if(attempts == 0)
{
    Console.WriteLine("You lose.");
}
Console.ReadKey();