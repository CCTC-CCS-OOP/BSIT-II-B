using System;

class VenturesMobileBanking
{
    static void Main()
    {
        // Program Structure and Basic Concepts
        Console.WriteLine("Welcome to Ventures Mobile Banking!");
        
        // Variables and Data Types
        string userName;
        double accountBalance = 1000.00;

        // User Input
        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        // More on Strings (\n \t @), Concatenation, and Interpolation
        Console.WriteLine($"\nHello, {userName}! \t Your account balance is: ${accountBalance:F2}");

        // Main Menu
        DisplayMenu();

        int choice;
        while (true)
        {
            // User Input
            Console.Write("\nEnter your choice (1-5): ");
            choice = int.Parse(Console.ReadLine());

            // Control Flow Statements
            switch (choice)
            {
                case 1:
                    // Account Balance
                    DisplayBalance(accountBalance);
                    break;
                case 2:
                    // Deposit
                    Console.Write("Enter the amount to deposit: $");
                    double depositAmount = double.Parse(Console.ReadLine());
                    accountBalance = Deposit(accountBalance, depositAmount);
                    break;
                case 3:
                    // Withdraw
                    Console.Write("Enter the amount to withdraw: $");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    accountBalance = Withdraw(accountBalance, withdrawAmount);
                    break;
                case 4:
                    // Fund Transfer
                    Console.Write("Enter the recipient's name: ");
                    string recipientName = Console.ReadLine();
                    Console.Write("Enter the amount to transfer: $");
                    double transferAmount = double.Parse(Console.ReadLine());
                    accountBalance = Transfer(accountBalance, transferAmount);
                    break;
                case 5:
                    // Exit
                    Console.WriteLine("Thank you for using Ventures Mobile Banking. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            // Display Menu Again
            DisplayMenu();
        }
    }




    // Methods and Parameters
    static void DisplayMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Transfer Funds");
        Console.WriteLine("5. Exit");
    }




    static void DisplayBalance(double balance)
    {
        Console.WriteLine($"\nYour account balance is: ${balance:F2}");
    }

    static double Deposit(double balance, double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposit successful. Your new balance is: ${balance:F2}");
        return balance;
    }





    static double Withdraw(double balance, double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance:F2}");
        }
        return balance;
    }





    static double Transfer(double balance, double amount)
    {
        // For simplicity, assuming successful transfer without checking balance
        balance -= amount;
        Console.WriteLine($"Transfer successful. Your new balance is: ${balance:F2}");
        return balance;
    }
}
