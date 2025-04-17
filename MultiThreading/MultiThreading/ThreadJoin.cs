using System;
using System.Threading;
class Test4{
    static void Add(){
        for(int i=0;i<5;i++){
            Console.WriteLine("hiii");
            
        }
    }
    static void Main(){
        Thread t1=new Thread(Add);
        t1.Start();
        t1.Join();
    }
}