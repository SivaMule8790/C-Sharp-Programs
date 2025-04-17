//delegation
using System;

public class Delegate1
{
    public delegate int del(int a, int b);
    public int add(int a,int b){
        return a+b;
    }
    public int sub(int a, int b){
        return a-b;
    }
    public static void Main(){
        Delegate1 obj=new Delegate1();
        del obj1=obj.add;
        Console.WriteLine(obj.add(45,46));
        del obj2=obj.sub;
        Console.WriteLine(obj.sub(43,4));
    }
}