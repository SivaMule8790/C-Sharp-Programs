using System;
public class c1{
    public void print(){
        Console.WriteLine("c1");
    }
    public class c2{
        public void display(){
            Console.WriteLine("Nested class");
        }
    }
}
class c3{
    static void Main(){
        c1 obj1=new c1();
        obj1.print();
        c1.c2 obj=new c1.c2();     //to call nested class
        obj.display();
    }
}