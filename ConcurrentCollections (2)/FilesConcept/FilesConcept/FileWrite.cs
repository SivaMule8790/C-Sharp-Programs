using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
      //no need of using TRY CATCH because it doesnt throws any Exception, It overrides Directly..
            string path="C:\\Users\\revat\\OneDrive\\Desktop\\Example.txt";
            using(StreamWriter f1=new StreamWriter(path)){
                f1.WriteLine("Hello");
              
            }
        
    }
}