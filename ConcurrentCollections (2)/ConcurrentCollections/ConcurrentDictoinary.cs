using System;
using System.Collections.Concurrent;
using SYstem.Threading.Tasks;
class ConcurrentEx{
    static void Main(string[] args ){
        ConcurrentDictoinary<int,string> c1=new ConcurrentDictoinary<int,string>();
        Parallel.For(0,10,i=>{
            c1.TryAdd(i,$"value{i}");
            Console.WriteLine($"Added:{i}->value{i}");
        });
        Console.WriteLine("Dequeue ELEmENTS");
        foreach(var k in c1){
            Console.WriteLine($"key:{k.key}, Value: {k.value}" );
        }
    
    }
}