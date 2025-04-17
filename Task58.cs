using System;
abstract class vehicle{
    public abstract void description(int n, string s1);
}
class info:vehicle{
    public override void description(int n, string s1){
        Console.WriteLine("The numver of wheels in a "+s1+" are "+n);
    }
        static void Main(string[] args){
            info obj1=new info();
            obj1.description(2,"Bike");
        }
}

/*
Vehicle Information System : Consider you are working in a manufacturing company where you are required
 to create an abstract class Vehicle with an abstract method description. Also, define the method in Category class
  which returns you the information of the vehicle as below:

Command line args 2 bike
The number of wheels in a bike are 2


Note : The description method should accept two parameters where the first parameter is of type int and second of type String
*/