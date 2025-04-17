using System;
using System.Collections.Generic;
class ienu{
    static void Main(){
        List<string> s1=new List<string>{"susfed","wafs","wwd"};
        IEnumerator<string> i1=s1.GetEnumerator();
        while(i1.MoveNext()){
            Console.WriteLine(i1.Current);
        }
    }
}