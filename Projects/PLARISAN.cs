using System;

class JohnCrisCalculator
{
    static void Main()
    {
        Console.WriteLine("John Cris Calculator!");
        Console.WriteLine("Hello User!");

        int num1, num2;

        Console.WriteLine("Enter two numbers:");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;
        float quotient = (float)num1 / num2;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");

        Console.WriteLine($"Addition: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"Division: {num1} / {num2} = {num1 / num2}");

        sum += 10;
        difference -= 5;
        product *= 2;
        quotient /= 2;
        Console.WriteLine($"Updated values - Sum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}");

        Console.WriteLine("Enter another number for additional calculation:");
        int additionalNumber = int.Parse(Console.ReadLine());
        int result = sum + additionalNumber;
        Console.WriteLine($"Additional Calculation: {sum} + {additionalNumber} = {result}");

        string newLineString = "This is on a new line.\n";
        string tabString = "This is indented with a tab.\t";
        string verbatimString = @"This is a verbatim string, \n and \t are treated as literal characters.";

        Console.WriteLine(newLineString);
        Console.WriteLine(tabString);
        Console.WriteLine(verbatimString);

        string firstName = "John Cris";
        string lastName = "Plarisan";
        string fullName = firstName + " " + lastName;
        string interpolatedFullName = $"{firstName} {lastName}";

        Console.WriteLine("Concatenated Full Name: " + fullName);
        Console.WriteLine("Interpolated Full Name: " + interpolatedFullName);


        Console.Write("Enter a number to compare with the first input: ");
        int comparisonNumber = int.Parse(Console.ReadLine());

        if (comparisonNumber == num1)
        {
            Console.WriteLine($"{comparisonNumber} is equal to the first input ({num1}).");
        }
        else if (comparisonNumber > num1)
        {
            Console.WriteLine($"{comparisonNumber} is greater than the first input ({num1}).");
        }
        else
        {
            Console.WriteLine($"{comparisonNumber} is less than the first input ({num1}).");
        }

        bool bothPositive = num1 > 0 && num2 > 0;
        bool anyNegative = num1 < 0 || num2 < 0;

        Console.WriteLine($"Are both numbers positive? {bothPositive}");
        Console.WriteLine($"Is at least one number negative? {anyNegative}");

        if (num1 % 2 == 0)
        {
            Console.WriteLine($"{num1} is an even number.");
        }
        else if (num1 % 2 != 0)
        {
            Console.WriteLine($"{num1} is an odd number.");
        }
        else
        {
            Console.WriteLine("This should not be reached, as the number should be either even or odd.");
        }

        Console.Write("Enter an operator (+, -, *, /): ");
        char operatorSymbol = char.Parse(Console.ReadLine());

        switch (operatorSymbol)
        {
            case '+':
                Console.WriteLine($"Result of addition: {num1 + num2}");
                break;
            case '-':
                Console.WriteLine($"Result of subtraction: {num1 - num2}");
                break;
            case '*':
                Console.WriteLine($"Result of multiplication: {num1 * num2}");
                break;
            case '/':
                Console.WriteLine($"Result of division: {(num2 != 0 ? ((float)num1 / num2).ToString() : "Cannot divide by zero")}");
                break;
            default:
                Console.WriteLine("Invalid operator entered.");
                break;
        }

        string greaterNumberMessage = (num1 > num2) ? $"{num1} is greater than {num2}" : $"{num1} is not greater than {num2}";
        Console.WriteLine(greaterNumberMessage);


        Console.WriteLine("Performing a for loop to calculate the power of a number:");

        int baseNumber = 2;
        int exponent = 3;
        int resultPower = 1;

        for (int i = 0; i < exponent; i++)
        {
            resultPower *= baseNumber;
        }

        Console.WriteLine($"{baseNumber}^{exponent} = {resultPower}");

        Console.WriteLine("\nPerforming a while loop to continuously get user input until a positive number is entered:");

        int userInput = 0;

        while (true)
        {
            Console.Write("Enter a positive number: ");
            userInput = int.Parse(Console.Read
