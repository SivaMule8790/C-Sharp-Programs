using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: "+number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: "+ex.Message);
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}