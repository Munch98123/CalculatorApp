using CalculatorApp.Operations;
using static CalculatorApp.IOperations.IOperations;

namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the Advanced Calculator!");
                Console.WriteLine("Please select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                string? choice = Console.ReadLine();

                if (choice == "5")
                {
                    running = false;
                    Console.WriteLine("Thank you for using the Advanced Calculator. Goodbye!");
                    continue;
                }
                else if (choice != null)
                {
                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    try
                    {
                        IOperations.IOperations operation = GetOperation(choice);
                        Calculator calculator = new Calculator(operation);
                        double result = calculator.PerformCalculation(num1, num2);
                        Console.WriteLine($"The result is: {result}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid character entered, please try again!");
                }



                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static IOperations.IOperations GetOperation(string choice)
        {
            switch (choice)
            {
                case "1":
                    return new Addition();
                case "2":
                    return new Subtraction();
                case "3":
                    return new Multiplication();
                case "4":
                    return new Division();
                default:
                    throw new InvalidOperationException("Invalid operation selected.");
            }
        }
    }
}
