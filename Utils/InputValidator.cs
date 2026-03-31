public class InputValidator
{
    public static int ReadInt(string message)
    {
        int value;
        Console.Write(message);

        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Input invalid. Try again: ");
        }

        return value;
    }
}