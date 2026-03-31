public static class GameEngine
{
    public static int GenerateNumber(int min, int max)
    {
        Random rnd = new Random();
        return rnd.Next(min, max + 1);
    }

    public static int SelectDifficulty()
    {
        Console.WriteLine(@" MENU:
        1. EASY LEVEL
        2. MEDIUM LEVEL
        3. HARD LEVEL
        ");

        int choice = Utils.InputValidator.ReadInt("Choose a difficulty: ");
        return choice;
    }
    public static void RunGame()
    {
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
            Console.WriteLine("Invalid choice. Defaulting to EASY.");
            max = 10;
            maxAttempts = 5;
        }

        int randomNum = GenerateNumber(min, max);
        int attempts = 0;
        bool isCorrect = false;
    
        Console.WriteLine($"\nGuess a number between {min} and {max}");

        while (!isCorrect && attempts < maxAttempts)
        {
            Console.WriteLine($"Attempts left: {maxAttempts - attempts}");

            int userGuess = Utils.InputValidator.ReadInt("Inform your guess: ");
            attempts++;

            if (userGuess == randomNum)
            {
                Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
                isCorrect = true;
            }
            else if (userGuess < randomNum)
            {
                Console.WriteLine("Too low! Try again.");
            } 
            else
            {
                Console.WriteLine("Too high! Try again.");
            }    
        }

        if (!isCorrect)
        {
            Console.WriteLine($"You lost! The number was {randomNum}");
        }
    }

//TODO: Clean the code, write a README and do some tests
}