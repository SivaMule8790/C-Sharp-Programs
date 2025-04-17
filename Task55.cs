//Take 1 Abstract class in that take 1 Abstract Method & 1 Static Method. 
// Now take 1 static class and try to Extends the Abstract class Methods in static class. =>not possible
using System;
public abstract class c1{
    public abstract void amet();
    public static void smet(){
        Console.WriteLine("static method");
    }
}
public static class c2:c1{
    public override void amet(){
        Console.WriteLine("Abstract method");
    }
    static void Main(){
        c2 obj1=new c2();
        obj1.amet();
        c1.smet();
    }
}
//Task55.cs(10,24): error CS0713: Static class 'c2' cannot derive from type 'c1'. Static classes must derive from object.
// Task55.cs(11,26): error CS0708: 'amet': cannot declare instance members in a static class