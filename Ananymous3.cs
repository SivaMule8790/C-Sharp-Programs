using System;
public class Ananymous3{
    public delegate void Show(string str1);
    public static void Main(){
        string s1="Vijay";
        Show s2=delegate(string s3){
            Console.WriteLine(s3);
            Console.WriteLine(s1);
        };
        s2("Govinda");
    }
}