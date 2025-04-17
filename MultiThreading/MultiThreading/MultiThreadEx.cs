using System;
class Sample{
    static void M1(){
        for(int i=0;i<4;i++){
            Console.WriteLine("Hello, Good Morning!!!!");
        }
    }
    static void M2(){
        for(int i=0;i<5;i++){
            Console.WriteLine("Hello, Good afternoon!!!!");
        }
    }
    static void M3(){
        for(int i=0;i<3;i++){
            Console.WriteLine("Hello, Good Evening!!!!");
        }
    }
    static void Main(){
        M1();
        M2();
        M3();
    }
}