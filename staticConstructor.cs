using System;
static class staticConstructor{
    static int a;
    static int b;
    static staticConstructor(){
        a=10;
        b=23;
        Console.WriteLine(a+" "+b);
    }
    static void Main(){
        
    }
}