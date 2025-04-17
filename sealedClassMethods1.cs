using System;
public class c1{
    public virtual void print(){
        Console.WriteLine("c1");
    }
}
public class c2:c1{
    public sealed override void print()
    {
        Console.WriteLine("c2");
    }
}
public class c4:c2{
    public override void print()  //cant override sealed method.
    {
        Console.WriteLine("c3");
    }
}

public class c3{
    static void Main(){
        c2 ob=new c2();
        ob.print();
        c1 ob1=new c1();
        ob1.print();
        c4 ob2=new c4();
        ob2.print();
    }
}