using System;

class RestaurantProgram
{
    static void Main()
    {
        // Variables and Data Types
        string restaurantName = "Food Station";
        int numberOfTables = 15;
        double averageMealPrice = 35.99;

        // Display restaurant information
        Console.WriteLine("============================");
        Console.WriteLine($"  Welcome to {restaurantName}!");
        Console.WriteLine("============================");
        Console.WriteLine($"We have {numberOfTables} tables available.");

        // User Input
        Console.Write("Enter the number of guests: ");
        int numberOfGuests = Convert.ToInt32(Console.ReadLine());

        // If-else Statement
        if (numberOfGuests > 0)
        {
            Console.WriteLine($"Great! You entered {numberOfGuests} guests.");

            // Method and Function
            double totalBill = CalculateBill(numberOfGuests, averageMealPrice);

            // Ternary Operator
            string discountMessage = (numberOfGuests > 5) ? "10% discount applied!" : "No discount applied.";

            // Display the total bill and discount message
            Console.WriteLine($"Your total bill is: ${totalBill:F2}");
            Console.WriteLine(discountMessage);
        }
        else
        {
            Console.WriteLine("Invalid number of guests. Please enter a valid number.");
        }
    }

    // Method to calculate the total bill
    static double CalculateBill(int guests, double pricePerMeal)
    {
        double totalBill = guests * pricePerMeal;
        return totalBill;
    }
}