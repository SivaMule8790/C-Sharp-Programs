using System;
class parent{
    public void display(){
        Console.WriteLine("parentClass");
    }
}
class child:parent{
    void print(){
        Console.WriteLine("ChildClass");
    }
    static void Main(){
        child c1=new child();
        c1.display();
        c1.print();
    }
}