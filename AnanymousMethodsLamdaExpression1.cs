using System;
class ana{
    public delegate int add(int x,int y);
    static void Main(){
        add s1=(x,y) => (x+y);
        Console.WriteLine(s1(445,550));
    }
}
/*  without lamda expression
using System;
class ana{
    public delegate void add(int x,int y);
    static void Main(){
        add s1= delegate(int a,int b){
            Console.WriteLine(a+b);
        };
        s1(45,550);
    }

}
*/