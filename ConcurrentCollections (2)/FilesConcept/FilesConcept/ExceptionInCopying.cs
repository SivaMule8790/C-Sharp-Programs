using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
        //IO Exception Occurs if you copy into Existed class does
        
       try{
         string source="C:\\Users\\revat\\OneDrive\\Desktop\\Example.txt";
    string dest="C:\\Users\\revat\\OneDrive\\Desktop\\Read.txt";
    File.Copy(source,dest);
       }
       catch(Exception e){
         Console.WriteLine(e.Message);
       }
    Console.WriteLine("Successs");

    }}