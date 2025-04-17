using System;
public interface in1{
    void print();
}
public class c1{
    public void print1(){
        Console.WriteLine("c1");
    }
}
public class c2:c1,in1{
    public void print(){
        Console.WriteLine("in1 met");
    }
}
class c3{
    static void Main(){
        in1 obj1 =new c2();
        obj1.print();
        c2 obj2=new c2();
        obj2.print1();      
    }
}