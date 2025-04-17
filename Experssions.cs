/*using System;

class Program
{
    static void Main(string[] args)
    {
        // Arithmetic Expressions
        int a = 10;
        int b = 5;
        int sum = a + b; // Arithmetic expression
        Console.WriteLine(sum); // Output: 15

        // Relational Expressions
        bool isEqual = (a == b); // Relational expression
        Console.WriteLine(isEqual); // Output: false

        // Logical Expressions
        bool x = true;
        bool y = false;
        bool result = x && y; // Logical expression
        Console.WriteLine(result); // Output: false

        // Bitwise Expressions
        int c = 5; // 0101 in binary
        int d = 3; // 0011 in binary
        int bitwiseAnd = c & d; // Bitwise expression
        Console.WriteLine(bitwiseAnd); // Output: 1

        // Assignment Expressions
        int e = 10; // Assignment expression
        e += 5; // e is now 15
        Console.WriteLine(e); // Output: 15

        // Conditional (Ternary) Expressions
        int f = (a > b) ? a : b; // Conditional expression
        Console.WriteLine(f); // Output: 10

        // Null Coalescing Expressions
        string name = null;
        string displayName = name ?? "Default Name"; // Null coalescing expression
        Console.WriteLine(displayName); // Output: Default Name

        // Lambda Expressions
        Func<int, int> square = x => x * x; // Lambda expression
        int squaredValue = square(6); // 36
        Console.WriteLine(squaredValue); // Output: 36

        // Method Call Expressions
        int total = GetSum(5, 10); // Method call expression
        Console.WriteLine(total); // Output: 15

        // Object Creation Expressions
        Person person = new Person { Name = "Alice" }; // Object creation expression
        Console.WriteLine(person.Name); // Output: Alice

        // Indexing Expressions
        int[] numbers = { 1, 2, 3, 4, 5 };
        int firstNumber = numbers[0]; // Indexing expression
        Console.WriteLine(firstNumber); // Output: 1
    }

    static int GetSum(int x, int y)
    {
        return x + y; // Method to get sum
    }
}

class Person
{
    public string Name { get; set; } // Property for Person class
}
*/