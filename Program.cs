class Program()
{
    public static void Main()
    {
        // generate a random number
        // asks for the user input
        // if userInput is write: user win, if not: user loose

        int randomNum = 10;

        Console.Write("Inform your guess: ");
        int userGuess = Convert.ToInt32(Console.ReadLine());

        if (userGuess == randomNum) {
            Console.WriteLine("You won!");
        } else
        {
            Console.WriteLine("Try again.");
        }
    }
}