using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
        string path="C:\\Users\\revat\\OneDrive\\Desktop\\Read.txt";
        using (StreamWriter w1=new StreamWriter(path,true)){
            w1.WriteLine("I Love Apples");
        }
        Console.WriteLine("successs");
    }
}