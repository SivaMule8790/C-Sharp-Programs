using System;
class Ananymous{
    public delegate void show(string str1);
    static void Main(){
        show s1=delegate(string str2){
            Console.WriteLine(str2);
        };
        s1("Govinda");
    }

}