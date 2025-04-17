/*
using System;
class cl{
    string name;
    string color;
    int cost;
    void Bike(){
            Console.WriteLine("name: "+name);
            Console.WriteLine("Color: "+color);
            Console.WriteLine("Cost: "+cost);
    }
    static void Main(){
        cl b1=new cl();
        b1.name="Duke";
        b1.color="black";
        b1.cost=160000;           //instance varible accessing
        b1.Bike();
        cl b2=new cl();
        b2.name="Duke2";
        b2.color="black2";
        b2.cost=160000;
        b2.Bike();
    }
}
*/
using System;
class cl{
    static string name;
    static string color;                     // static variable access
    static int cost;
    void Bike(){
            Console.WriteLine("name: "+name);
            Console.WriteLine("Color: "+color);
            Console.WriteLine("Cost: "+cost);
    }
    static void Main(){
        cl b1=new cl();
        cl.name="Duke";
        cl.color="black";
        cl.cost=160000;
        b1.Bike();
    }
}