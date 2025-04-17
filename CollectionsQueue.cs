using System;
using System.Collections.Generic;
class Queue1{
    public static void Main(string[] args){
        Queue<int> a=new Queue<int>();
        a.Enqueue(1);
        a.Enqueue(2);
        a.Enqueue(3);
        Display(a);
        Console.WriteLine("top of the queue: "+a.Peek());
        int a1=a.Dequeue();
        Console.WriteLine("Poped element of the queue: "+a1);
        Display(a);
        Console.WriteLine("is queue Empty: "+(a.Count==0));
        a.Clear();
        Display(a);
    }
    public static void Display(Queue<int> queue){
        Console.WriteLine("Queue Elements: ");
        foreach(int a1 in queue){
             Console.WriteLine(a1);
        }
    }
}