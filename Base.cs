// used to take immediate parent class properties into base class. Same as super keyword in java
using System;
public class par{
    public int a=10;
    public par(){
        Console.WriteLine("par constructor"); 
    }
    public void print(){
        Console.WriteLine("par print");
    }
}
public class ch:par{
    public ch():base(){
        Console.WriteLine("child");
    }
    public void Display(){
        base.print();
        Console.WriteLine(base.a);
        Console.WriteLine("child met");
    }
    static void Main(){
        ch obj=new ch();
        obj.Display();
    }
}