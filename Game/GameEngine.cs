public static class GameEngine
{
    public static int GenerateNumber()
    {
        Random rnd = new Random();
        return rnd.Next(0, 11);
    }

    public static void RunGame()
    {
        int randomNum = GenerateNumber();
        bool isCorrect = false;

        // Console.Write(randomNum);
    
        while (!isCorrect)
        {
            int userGuess = Utils.InputValidator.ReadInt("Inform your guess: ");

            if (userGuess == randomNum)
            {
                Console.WriteLine("Correct! You guessed the number.");
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
    }

}