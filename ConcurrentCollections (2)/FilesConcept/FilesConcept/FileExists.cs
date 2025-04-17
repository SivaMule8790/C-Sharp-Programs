using System;
using System.IO;
class Tempo{
    static void Main(string[] args){
       
        
    string dest="C:\\Users\\revat\\OneDrive\\Desktop\\Read2.txt";
if(File.Exists(dest)){
    File.Delete(dest);
    Console.WriteLine("success");
}
else{
    Console.WriteLine("File Not Existed...");
}
 }
 }