namespace Utils
{
    public class InputValidator
    {
        public static int ReadInt(string message)
        {
            int result;
            bool isValid = false;

            do
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                isValid = int.TryParse(input, out result);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

            } while (!isValid);
            
            return result;
        }
    } 
}
