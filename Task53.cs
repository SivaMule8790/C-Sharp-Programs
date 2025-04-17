// Is it possible to extend 1 abstract class for multiple normal class.
using System;
public abstract class s1{
    public abstract void sound();
}
public class s2:s1{
    public override void sound() {
        Console.WriteLine("baa");
    }
}
public class s3:s1{
    public override void sound()
    {
        Console.WriteLine("caa");
    }
}
public class s4{
    static void Main(){
        s2 obj1=new s2();
        s3 obj2=new s3();
        obj1.sound();
        obj2.sound();
    }
}