
namespace CalculatorApp
{
    internal class Option
    {
        static Operation Op = new Operation();
        static List<string> listItems = new List<string>();

        public static void GetOperands(string choice)
        {
            if (choice == "5")
            {
                Op.DisplayHistory(listItems);
                return;
            }

            Console.WriteLine("Enter 1st value: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd value: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            SelectOption(choice, num1, num2);
        }
        public static void SelectOption(string selection, int n1, int n2)
        {
            string resultMessage = "";

            switch (selection)
            {
                case "1":
                    resultMessage = $"Result of sum  {n1} + {n2} = {Op.Addition(n1, n2)}";
                    break;
                case "2":
                    resultMessage = $"Result of sub {n1} - {n2} = {Op.Difference(n1, n2)}";
                    break;
                case "3":
                    resultMessage = $"Result of mul {n1} * {n2} = {Op.Multiplication(n1, n2)}";
                    break;
                case "4":
                    resultMessage = $"Result of div {n1} / {n2} = {Op.Division(n1, n2)}";
                    break;
                default:
                    resultMessage = "Invalid selection";
                    break;
            }

            Operation.Display(resultMessage);
            listItems.Add(resultMessage);
        }

    }
}
