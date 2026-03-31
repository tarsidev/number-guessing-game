public static class GameEngine
{
    public static int GenerateNumber()
    {
        Random rnd = new Random();

        int randomNum = rnd.Next(0, 11);
        return randomNum;
    }

    public static int UserGuess()
    {
        Console.Write("Inform your guess: ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        return userGuess;
    }

}