//Take one abstract class implement abstract,instance and static methods.
using System;
public abstract class Ts1{
    public abstract void display1();
    public void display2(){
        Console.WriteLine("Instance method");
    }
    public static void display3(){
        Console.WriteLine("Static method");
    }

}
class Ts2:Ts1{
    public override void display1(){
        Console.WriteLine("Abstract Methood");
    }
    static void Main(){
        Ts2 obj1=new Ts2();
        obj1.display1();
        obj1.display2();
        display3();
    }
}