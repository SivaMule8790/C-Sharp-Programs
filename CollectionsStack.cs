using System;
using System.Collections.Generic;
class st{
    static void Display(Stack<int> s){
        foreach(int i in s){
            Console.WriteLine(i);
        }
    }
    static void Main(){
        Stack<int> s1=new Stack<int>();
        s1.Push(566);
        s1.Push(5626);
        s1.Push(5);
        s1.Push(6);
        s1.Push(52);
        Console.WriteLine("Before pop: ");
        Display(s1);
        Console.WriteLine("Peak element: "+s1.Peek());
        Console.WriteLine("count: "+s1.Count);
        s1.Pop();
        Console.WriteLine("After pop: ");
        Display(s1);
        s1.Clear();
        Console.WriteLine("After clear: ");
    }
}