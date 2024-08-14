
namespace CalculatorApp
{
    internal class Operation
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2; 
        }

        public double Difference(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double x, double y)
        {
            return x / y;
        }

        public static void Display(string res)
        {
            Console.WriteLine(res);
        }

        public void DisplayHistory(List<string> listItems)
        {
            Console.WriteLine("Result history");
            foreach (string i in listItems)
            {
                Console.WriteLine(i);
            }
        }
    }
}
