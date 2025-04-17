using System;
class AllConstructors{
    private string name;
    private int age;
    public AllConstructors(){         //default Constructor
        name="default";
        age=33;
    }
    public AllConstructors(string name){     //parameterized
        this.name=name;
        age=23;
    }
    public AllConstructors(string name,int age){     //overloading
        this.name=name;
        this.age=age;
    }
    public AllConstructors(AllConstructors c1){     //copied 
        this.name=c1.name;
        this.age=c1.age;
    }
    public void display(){
        Console.WriteLine("name "+name+" age"+age);
    }
    static void Main(){
        AllConstructors c2=new AllConstructors();
        c2.display();
        AllConstructors c3=new AllConstructors("parameterized");
        c3.display();
        AllConstructors c4=new AllConstructors("overloadong",456);
        c4.display();
        AllConstructors c5=new AllConstructors(c4);
        c5.display();
    }
}