using System;
using System.Threading;
class Sample{
    static void Show(){
        for(int i=0;i<10;i++){
            Console.WriteLine("HIi");
             if(i==3){
                Thread.Sleep(1000);
            }
        }
    }
    static void Show2(){
        for(int i=0;i<3;i++){
            Console.WriteLine("Hloooo");
           
        }
    }

    static void Main(string[] args){
       Thread t1=new Thread(Show);
       t1.Start();
       Thread t2=new Thread(Show2);
        t2.Start();
        t2.Join();
        Console.WriteLine("Finished");
    }
}