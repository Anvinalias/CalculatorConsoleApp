using CalculatorLibrary;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Option Op = new Option();
            string? continueChoice;
            string? userChoice;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            do
            {
                Console.WriteLine("Choose from below choices ?");

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Previous results");
                Console.WriteLine("6. Quit");

                userChoice = Console.ReadLine();

                if (userChoice == "6")
                {
                    break;
                }

                Op.GetOperands(userChoice);

                Console.WriteLine("Do you want to continue? Y or N ");
                continueChoice = Console.ReadLine();

            } while (continueChoice != "n" && continueChoice != "N");

        }
    }
}
