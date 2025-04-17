using System;
class encap{
    private int age;
    private string name;
    public int Age{
        get{
            return age;
        }
        set{
            age=value;
        }
    }
    public string Name{
        get{
            return name;
        }
        set{
            name=value;
        }
    }
    static void Main(){
        encap e=new encap();
        e.Name="wedf";
        e.Age=45;
        Console.WriteLine("Name is: {0}",e.name);
        Console.WriteLine("Age is: {0}",e.age);
    }
}