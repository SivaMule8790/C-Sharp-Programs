using System;
class def{
    static void display(string name="default"){       //Default parameters
        Console.WriteLine(name);
    }
    static void Main(){
        display("namdfge");
        display();
    }
}