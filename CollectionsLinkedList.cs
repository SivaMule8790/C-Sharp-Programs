using System;
using System.Collections.Generic;
using System.Linq;
class coll{
    static void Main(){
        LinkedList<int> l1=new LinkedList<int>();
        l1.AddLast(452);
        l1.AddLast(425);
        l1.AddLast(465);
        l1.AddLast(452);
        l1.AddLast(258);

        l1.AddFirst(22);
        l1.Remove(465);
        Console.WriteLine(l1.Contains(258));
        //var i1=l1.Where(n => n%2==0);
        //foreach(int i in i1){
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine(l1);
        //IEnumerator<int> en=l1.GetEnumerator();
        //while(en.MoveNext()){
        //    Console.WriteLine(en.Current);
        //}
        foreach(int i in l1){
            Console.WriteLine(i);
        }
    }
}