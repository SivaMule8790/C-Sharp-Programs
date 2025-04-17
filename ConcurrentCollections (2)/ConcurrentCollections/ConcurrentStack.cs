using System;
using System.Collections.Concurrent;
using SYstem.Threading.Tasks;
class ConcurrentEx{
    static void Main(string[] args ){
        ConcurrentStack<int> c1=new ConcurrentStack<int>();
        Parallel.For(0,10,i=>{
            c1.Push(i);
            Console.WriteLine(i);
        });
        Console.WriteLine("POP ELEmENTS");
        while(c1.TryPop(out int res)){
            Console.WriteLine(res);
        }
    }
}