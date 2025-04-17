using System;
class rearrange{
    static void display(string name, int marks){
        Console.WriteLine("name "+name+" marks "+marks);
        Console.WriteLine("marks "+marks+" name "+name);
    }
    static void Main(){
        display(name:"wse",marks:678);
    }
}