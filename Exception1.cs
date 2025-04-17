using System;

class Program
{
    static void Main()
    {
        try
        {
            // Code that may throw exceptions
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // This will throw IndexOutOfRangeException
            int result = 10 / 0; // This will throw DivideByZeroException
        }
        catch (Exception ex){
        if(ex is IndexOutOfRangeException || ex is DivideByZeroException)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        else 
        {
            Console.WriteLine("A general error occurred: "+ex.Message);
        }
        }
    }
}