using System;

class Program
{
    static void Main(string[] args)
    {
        // Example of for loop
        Console.WriteLine("For Loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // Example of while loop
        Console.WriteLine("\nWhile Loop:");
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine(count);
            count++;
        }

        // Example of do-while loop
        Console.WriteLine("\nDo-While Loop:");
        int number = 0;
        do
        {
            Console.WriteLine(number);
            number++;
        } while (number < 5);

        // Example of foreach loop
        Console.WriteLine("\nForeach Loop:");
        string[] fruits = { "Apple", "Banana", "Cherry" };
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}