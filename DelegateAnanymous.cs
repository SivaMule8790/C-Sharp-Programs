using System;
public class A{
    public delegate void Display(string str1);
}
public class DelegateAnanymous{
    public static void Show(A.Display x,string name ){
        x(name);
    }
    static void Main(){
        Show(delegate(string name){
            Console.WriteLine(name);
        },"Ram");
    }
}