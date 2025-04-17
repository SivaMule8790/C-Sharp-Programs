using System;
class AnanymousClass{
    public void Add(){
            Console.WriteLine("add");
        }
    static void Main(){
        
        var s1=new{
            Name="Vijay",
            Age=21,
            City="Narasaraopet"
        };
        s1.Add();
        Console.WriteLine(string.Format("Name:{0}\nAge:{1}\nCity:{2}",s1.Name,s1.Age,s1.City));
    }
}