using System;
class con{
    int age;
    public con(int Age){
        age=Age;
        Console.WriteLine(Age);
    }
    public con(){
        Console.WriteLine("Default Constructor");
    }
    static void Main(){
        con c1= new con();                //Constuctor is called when an object is created
        con c2=new con(45);
        Console.WriteLine(c2.age);
    }
}