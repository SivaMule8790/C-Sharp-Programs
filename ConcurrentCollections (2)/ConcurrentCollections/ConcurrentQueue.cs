using System;
using System.Collections.Concurrent;
using SYstem.Threading.Tasks;
class ConcurrentEx{
    static void Main(string[] args ){
        ConcurrentQueue<int> c1=new ConcurrentQueue<int>();
        Parallel.For(0,10,i=>{
            c1.Enqueue(i);
            Console.WriteLine(i);
        });
        Console.WriteLine("Dequeue ELEmENTS");
        while(c1.TryDequeue(out int res)){
            Console.WriteLine(res);
        }
    }
}