using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
        //IO Exception Occurs if you copy into Existed class does
        //It only Copies to NEw File
         string source="C:\\Users\\revat\\OneDrive\\Desktop\\Example.txt";
    string dest="C:\\Users\\revat\\OneDrive\\Desktop\\Read1.txt";
    File.Copy(source,dest);
    Console.WriteLine("Successs");

    }}