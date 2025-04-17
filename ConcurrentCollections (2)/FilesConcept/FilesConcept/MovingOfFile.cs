using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
       
         string source="C:\\Users\\revat\\OneDrive\\Desktop\\Example.txt";
    string dest="C:\\Users\\revat\\OneDrive\\Desktop\\Read2.txt";
    File.Move(source,dest);
    Console.WriteLine("Successs");
    }
}