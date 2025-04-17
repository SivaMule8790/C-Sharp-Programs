using System;
class met{
    int a1=12, a2=34; //Instance variables
    static int b1=78,b2=52; //Static variables
    void show(){     //Instance Method both instance and static variables can access
        Console.WriteLine(a1+a2);
        Console.WriteLine(b1+b2);
    }
    static void display(){  // Static method only static variables can access
        Console.WriteLine(b1+b2);
    }
    void print(){
        show1(); //Local method
    }
    void show1(){     //Local method
            Console.WriteLine("Local method");
        }
    static void Main(string[] args){
        met m1=new met();
        m1.show();
        display();
        m1.print();
    }
}

/*
class met{
    void add(int a, int b){       //Local Method.
        Console.WriteLine(a+b);  // Only runs on online compliler not in vscode due to version.
    }
    add(20,200);
}
*/