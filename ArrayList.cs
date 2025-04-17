using System;
using System.Collections;
//data types for single type
//var is used only for key value pair
// object for multiple values
class ArrayList1{
    
    public static void Main(string[] args){
    ArrayList a1=new ArrayList();
    a1.Add(1);
    a1.Add("hi");
    a1.Add(1.23);
    a1.Add(true);
    Display(a1);
    a1.Insert(1,"Hello");
    Display(a1);
    a1.Remove("hi");
    Display(a1);
    Console.WriteLine("Count of Elements in Arraylist:"+a1.Count);
    }
    public static void Display(ArrayList b){
        Console.WriteLine("ArrayList Elements");
        foreach(object n in b){
        Console.WriteLine(n);
    }
    }
}