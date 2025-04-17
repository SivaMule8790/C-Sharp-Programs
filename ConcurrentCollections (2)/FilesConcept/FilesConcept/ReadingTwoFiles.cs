using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
        string path="C:\\Users\\revat\\OneDrive\\Desktop\\Read1.txt";
    string path2="C:\\Users\\revat\\OneDrive\\Desktop\\Read.txt";
    using(StreamReader w1=new StreamReader(path))
    using(StreamReader w2=new StreamReader(path2)){
        string line,line2;
       while((line=w1.ReadLine())!=null && (line2=w2.ReadLine())!=null ){
                Console.WriteLine(line);
                Console.WriteLine(line2);
            }
    }
    }
}