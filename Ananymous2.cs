using System;
class Ananymous2{
    public delegate void show(string str1);
    public delegate void Print(int age1);
    static void Main(){
        show s1=delegate(string str2){
            Console.WriteLine(str2);
        };
        Print s2=delegate(int age2){
             Console.WriteLine(age2);
        };
        s1("Govinda");
        s2(21);
    }

}