using System;
using System.Collections;
class hash{
    static void display(Hashtable h){
        foreach(DictionaryEntry n in h){
            Console.WriteLine(n.Key+" "+n.Value);
        }
    }
    static void Main(){
        Hashtable h1=new Hashtable();
        h1.Add("dsg",66);
        h1.Add("dg",422);
        h1.Add("atdsg",44);
        h1.Add("g",6);
        display(h1);
    }
}