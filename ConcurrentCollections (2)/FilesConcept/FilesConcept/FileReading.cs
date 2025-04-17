using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
        string path="C:\\Users\\revat\\OneDrive\\Desktop\\Example.txt";
        using(StreamReader w2=new StreamReader(path)){
            string line;
            while((line=w2.ReadLine())!=null){
                Console.WriteLine(line);
            }
        }
      
    }
}