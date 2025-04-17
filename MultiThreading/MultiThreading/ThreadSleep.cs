using System;
using System.Threading;
class Test4{
    void Add(){
        for(int i=0;i<5;i++){
            Console.WriteLine("hiii");
            if(i==2){
                Thread.Sleep(10000);
            }
        }
    }
    static void Main(){
        Test4 t1=new Test4();
        t1.Add();
    }
}