using System;
using System.Threading;
class Sample{
    static void Main(string[] args){
        Thread n=Thread.CurrentThread;
        n.Name="Ankitha";
        Console.WriteLine(n.Name);
    }
}