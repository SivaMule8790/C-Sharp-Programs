//delegation
using System;

public class Delegate
{
    // Delegate definitions
    public delegate void AddDelegate(int a, int b);
    public delegate void SubDelegate(int a, int b);

    // Methods matching delegate signature
    public void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    public void Sub(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

    public static void Main()
    {
        Delegate obj = new Delegate();

        // Creating delegate instances
        AddDelegate addDel = obj.Add;
        SubDelegate subDel = obj.Sub;

        // Invoking delegates
        addDel(10, 20);
        subDel(30, 20);
    }
}
