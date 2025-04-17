using System;
class op{
    static void Main(string[] args){
        int? a=null;   // '?'  to handle null exceptions.
        int b=34;
        int res=a ?? b ; // '??' to take not null value
        Console.WriteLine(res);
        char? fname=null;
        char lname='m';
        char r=fname ?? lname;
        Console.WriteLine(r);
        Console.WriteLine(a);
    }
}
/*
using System;

class Program
{
    // Indexer example
    class Sample
    {
        private int[] arr = new int[10];

        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }

    static void Main(string[] args)
    {
        // Arithmetic Operators
        int a = 10;
        int b = 3;
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"Addition: {a + b}"); // 13
        Console.WriteLine($"Subtraction: {a - b}"); // 7
        Console.WriteLine($"Multiplication: {a * b}"); // 30
        Console.WriteLine($"Division: {a / b}"); // 3
        Console.WriteLine($"Modulus: {a % b}"); // 1

        // Relational Operators
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine($"Is Equal: {a == b}"); // false
        Console.WriteLine($"Is Greater: {a > b}"); // true

        // Logical Operators
        bool x = true;
        bool y = false;
        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine($"Logical AND: {x && y}"); // false
        Console.WriteLine($"Logical OR: {x || y}"); // true

        // Bitwise Operators
        Console.WriteLine("\nBitwise Operators:");
        int c = 5; // 0101 in binary
        int d = 3; // 0011 in binary
        Console.WriteLine($"Bitwise AND: {c & d}"); // 1 (0001)
        Console.WriteLine($"Bitwise OR: {c | d}"); // 7 (0111)

        // Assignment Operators
        Console.WriteLine("\nAssignment Operators:");
        int e = 10;
        e += 5; // e is now 15
        Console.WriteLine($"After += 5: {e}"); // 15
        e *= 2; // e is now 30
        Console.WriteLine($"After *= 2: {e}"); // 30

        // Unary Operators
        Console.WriteLine("\nUnary Operators:");
        int f = 5;
        Console.WriteLine($"Original: {f}");
        Console.WriteLine($"Increment: {++f}"); // 6
        Console.WriteLine($"Decrement: {--f}"); // 5

        // Ternary Operator
        Console.WriteLine("\nTernary Operator:");
        int g = (f > 5) ? 10 : 20; // g will be 20
        Console.WriteLine($"Value of g: {g}"); // 20

        // Null Coalescing Operator
        Console.WriteLine("\nNull Coalescing Operator:");
        string name = null;
        string displayName = name ?? "Default Name"; // displayName will be "Default Name"
        Console.WriteLine($"Display Name: {displayName}");

        // Type Comparison Operator
        Console.WriteLine("\nType Comparison Operator:");
        object obj = "Hello";
        if (obj is string)
        {
            Console.WriteLine("It's a string!");
        }
        string str = obj as string; // str will be "Hello"
        Console.WriteLine($"String value: {str}");

        // Member Access Operator
        Console.WriteLine("\nMember Access Operator:");
        Sample sample = new Sample();
        sample[0] = 100; // Using indexer to set value
        Console.WriteLine($"Value at index 0: {sample[0]}"); // 100
    }
}
*/