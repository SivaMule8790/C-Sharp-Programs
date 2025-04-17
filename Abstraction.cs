using System;
abstract class ab{
    public abstract void display();
}
class ab1:ab{
    public override void display()
    {
        Console.WriteLine("dis");
    }
    public void print(){
        Console.WriteLine("print");
    }
    static void Main(){
        ab1 o1=new ab1();
        o1.display();
        o1.print();
    }
}
