using System;
class Task22
{
    static int add(int a,int b,int c){
        return a+b+c;
    }
    static void Main(){
        int a=10;
        int _b=20;
        int @c=30;
        Console.WriteLine(add(a,_b,@c));
    }
}
/*perform the operations on the 3 different variables
 1. Normal 2. _underscore 3. @ and using these 3 variables perform arithmetic operations with methods and call the methods.*/