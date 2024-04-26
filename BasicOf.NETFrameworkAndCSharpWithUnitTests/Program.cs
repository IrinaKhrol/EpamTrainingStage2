namespace BasicOfNETFrameworkAndCSharpWithUnitTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int maxConsecutiveLetters = Message.GetMaxConsecutiveLatinLetters(input);
            int maxConsecutiveDigits = Message.GetMaxConsecutiveDigits(input);

            Console.WriteLine($"Max consecutive Latin letters: {maxConsecutiveLetters}");
            Console.WriteLine($"Max consecutive digits: {maxConsecutiveDigits}");
        }
    }
}