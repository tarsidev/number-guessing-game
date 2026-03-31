using Utils;

public static class GameEngine
{
    private static Random rnd = new Random();

    public static void ShowHeader()
    {
        Console.Clear();
        Console.Title = "Number Guessing Game";

        Console.WriteLine("=====================================");
        Console.WriteLine("       NUMBER GUESSING GAME       ");
        Console.WriteLine("=====================================\n");
    }

    public static int GenerateNumber(int min, int max)
    {
        return rnd.Next(min, max + 1);
    }

    public static int SelectDifficulty()
    {
        Console.WriteLine("Select Difficulty:\n");
        Console.WriteLine("[1] Easy   (0–10, 5 attempts)");
        Console.WriteLine("[2] Medium (0–50, 7 attempts)");
        Console.WriteLine("[3] Hard   (0–100, 10 attempts)\n");

        int choice = Utils.InputValidator.ReadInt("Choose a difficulty: ");
        return choice;
    }

    public static void RunGame()
    {
        //ShowHeader();

        int choice = SelectDifficulty();

        int min = 0;
        int max;
        int maxAttempts;
        
        if (choice == 1)
        {
            max = 10;
            maxAttempts = 5; 
        } 
        else if (choice == 2)
        {
            max = 50;
            maxAttempts = 7; 
        } 
        else if (choice == 3)
        {
            max = 100;
            maxAttempts = 10;
        } 
        else
        {
            Console.WriteLine("\nInvalid choice. Defaulting to EASY.\n");
            max = 10;
            maxAttempts = 5;
        }

        int randomNum = GenerateNumber(min, max);
        int attempts = 0;
        bool isCorrect = false;
    
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"\nGuess a number between {min} and {max}\n");

        while (!isCorrect && attempts < maxAttempts)
        {
            Console.WriteLine($"Attempts left: {maxAttempts - attempts}");

            int userGuess = InputValidator.ReadInt("> ");
            attempts++;

            if (userGuess == randomNum)
            {
                Console.WriteLine($"\nCorrect! You guessed the number in {attempts} attempts.");
                isCorrect = true;
            }
            else if (userGuess < randomNum)
            {
                Console.WriteLine("Too low! Try again.\n");
            } 
            else
            {
                Console.WriteLine("Too high! Try again.\n");
            }    
        }

        if (!isCorrect)
        {
            Console.WriteLine($"\nYou lost! The number was {randomNum}.");
        }

        Console.WriteLine("\n=====================================");
        Console.WriteLine("       GAME OVER       ");
        Console.WriteLine("=====================================");
    }

    public static void Start()
    {
        bool playAgain;

        do
        {
            ShowHeader();
            RunGame();
            playAgain = AskPlayAgain();
        } while (playAgain);
    }

    public static bool AskPlayAgain()
    {
        while(true)
        {
            Console.Write("\nDo you want to play again? (Y/N): ");
            string input = Console.ReadLine()?.Trim().ToUpper();

            if (input == "Y" || input == "YES")
            {
                return true;
            } else if (input == "N" || input == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please type Y or N.");
            }
        }
    }
}