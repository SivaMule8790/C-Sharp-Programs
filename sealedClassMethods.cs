using System;

public class BaseClass
{
    public virtual void Display()        //virtual is used to allow override of a method
    {
        Console.WriteLine("BaseClass Display");
    }
}

// Sealed class
public sealed class SealedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("SealedClass Display");
    }
}

// Attempting to inherit from a sealed class will cause a compile-time error
//public class DerivedClass : SealedClass        //sealedClassMethods.cs(21,14): error CS0509: 'DerivedClass': cannot derive from sealed type 'SealedClass'
                                                // sealedClassMethods.cs(12,21): (Location of symbol related to previous error)
//{
//}

class Program
{
    static void Main()
    {
        BaseClass obj1=new BaseClass();
        obj1.Display();
        SealedClass obj = new SealedClass();
        obj.Display(); // Output: SealedClass Display
    }
}
/*
using System;
public class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("BaseClass Display");
    }
}

public class DerivedClass : BaseClass
{
    public sealed override void Display()
    {
        Console.WriteLine("DerivedClass Display");
    }
}

public class FurtherDerivedClass : DerivedClass
{
    // Attempting to override Display() here will cause a compile-time error
    // public override void Display()
    // {
    //     Console.WriteLine("FurtherDerivedClass Display");
    // }
}

class Program
{
    static void Main()
    {
        DerivedClass obj = new DerivedClass();
        obj.Display(); // Output: DerivedClass Display
    }
}*/