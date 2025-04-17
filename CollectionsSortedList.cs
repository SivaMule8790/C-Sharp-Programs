using System;
using System.Collections.Generic;
class SortedList1{
    public static void Main(string[] args){
        SortedList<string,int> a=new SortedList<string,int>();
        a.Add("a",1);
        a.Add("b",2);
        a.Add("c",3);
        a.Add("d",3);
        Display(a);
        Console.WriteLine("Value for 'a': "+a["a"]);
        bool a1=a.Remove("c");
        Display(a);
        Console.WriteLine("Contains 'b': "+a.ContainsKey("b"));
        Display(a);
        Console.WriteLine("Contains 'b': "+a.ContainsKey("b"));
        Display(a);
        Console.WriteLine("Iterating foreach");
        foreach(var k in a){
            Console.WriteLine(string.Format("{0}: {1}",k.Key,k.Value));
        }
        Console.WriteLine("Count of Elements: "+a.Count);
        a.Clear();
        Console.WriteLine("Count of Elements: "+a.Count);
        
    }
    public static void Display(SortedList<string,int> sortedlist){
        Console.WriteLine();
        Console.WriteLine("SortedList Elements: ");
        foreach(var m in sortedlist){
             Console.WriteLine(string.Format("{0}:{1}",m.Key,m.Value));
        }
        
        
    }
}