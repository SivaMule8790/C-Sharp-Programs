using System;

class Program
{
    static void Main(string[] args)
    {
        // Example of if statement
        int number = 10;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }

        // Example of if-else statement
        number = -5;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is not positive.");
        }

        // Example of else if statement
        number = 0;
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }

        // Example of switch statement
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
            }

        // Example of conditional (ternary) operator
        number = 5;
        string result = (number > 0) ? "Positive" : "Not Positive";
        Console.WriteLine(result); // Output: Positive
    }
}