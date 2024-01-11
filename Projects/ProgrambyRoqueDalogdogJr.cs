using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"\nHello, {name}! Welcome to the Simple Calculator.");

            while (true)
            {
                DisplayMenu();

                int operation = GetOperationChoice();

                if (operation == 0)
                {
                    Console.WriteLine("Exiting the program...goodbye!");
                    break;
                }

                int num1 = GetNumber("Enter the first number: ");
                int num2 = GetNumber("Enter the second number: ");

                PerformOperation(operation, num1, num2);
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("- 1 - Addition -");
            Console.WriteLine("- 2 - Subtraction -");
            Console.WriteLine("- 3 - Multiplication -");
            Console.WriteLine("- 4 - Division -");
            Console.WriteLine("- 5 - Remainder -");
            Console.WriteLine("- 0 - Exit -");
            Console.WriteLine("---------------------------------------");
        }

        static int GetOperationChoice()
        {
            Console.Write("Please choose an operation: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GetNumber(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PerformOperation(int operation, int num1, int num2)
        {
            switch (operation)
            {
                case 1:
                    DisplayResult(num1 + num2);
                    break;
                case 2:
                    DisplayResult(num1 - num2);
                    break;
                case 3:
                    DisplayResult(num1 * num2);
                    break;
                case 4:
                    if (num2 != 0)
                        DisplayResult(num1 / num2);
                    else
                        Console.WriteLine("\nCannot divide by zero.");
                    break;
                case 5:
                    if (num2 != 0)
                        DisplayResult(num1 % num2);
                    else
                        Console.WriteLine("\nCannot compute remainder with zero.");
                    break;
                default:
                    Console.WriteLine("\nInvalid Input");
                    break;
            }
        }

        static void DisplayResult(int result)
        {
            Console.WriteLine($"\nResult: {result}\n");

            Console.Write("Do you want to operate again? (1-yes, 0-no): ");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 0)
            {
                Console.WriteLine("\nThank you for using the calculator. Goodbye!");
                Environment.Exit(0);
            }
        }
    }
}