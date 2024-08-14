﻿
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

            try
            {
                Console.WriteLine("Enter 1st value: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd value: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                SelectOption(choice, num1, num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input enter numbers");
            }
    
        }
        public static void SelectOption(string selection, double n1, double n2)
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
                    while(n2 == 0)
                    {
                        Console.WriteLine("Divisor cant be zero");
                        Console.WriteLine("Choose divisor again: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                    }
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
