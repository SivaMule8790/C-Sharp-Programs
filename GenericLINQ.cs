using System;
using System.Collections.Generic;
using System.Linq;
class linq{
    static void Main(){
        List<string> s1=new List<string>{"shuj","sfs","wdas"};
        var s2=s1.Where(n=>n.StartsWith("s"));
        foreach(var i in s2){
            Console.WriteLine(i);
        }
    }
}