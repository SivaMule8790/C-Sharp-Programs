// Take two Abstract classes. In 1 Abstract class take. 2 Abstract Methods and in another Abstract class take. 
// 1 Abstract Method and.. 1 static Method and try to implement (or)extends both Abstract Classes in Normal classes
using System;
public abstract class class1{
    public abstract void amet1();
    public abstract void amet2();
}
public abstract class class2{
    public abstract void amet3();
    public static void smet1(){
        Console.WriteLine("static method");
    }
}
public class class3:class1{
    public override void amet1(){
        Console.WriteLine("Abstract method-1");
    }
    public override void amet2(){
        Console.WriteLine("Abstract method-2");
    }
}
public class class4:class2{
    public override void amet3(){
        Console.WriteLine("Abstract method-3");
    }
}
public class class5{
    static void Main(){
        class3 obj1=new class3();
        class4 obj2=new class4();
        obj1.amet1();
        obj1.amet2();
        obj2.amet3();
        class2.smet1();
    }
}
 