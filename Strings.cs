using System;
class st{
    static void Main(){
        string s1="subhani";
        string s10="subhani";
        string s2="kalyan";
        string s3="14";
        int s4=45;
        string s5=new string("kalyan".ToCharArray());
        object ob1="object";
        string s6=ob1.ToString();
        //string s5=new string("ee");  //No string class in c#
        Console.WriteLine(s1+s3+100+'@');
        Console.WriteLine(string.Concat(s4,'@',11));  //string.Concat()
        Console.WriteLine(s5); 
        Console.WriteLine(s5==s2);  // compares only content
        Console.WriteLine(object.ReferenceEquals(s5,s2)); //compares both content and refernce
        Console.WriteLine(s2.Equals(s5));  //compares only content
        Console.WriteLine(s1.CompareTo(s2));  //compares alphabet order and return 1 or 0 or -1
        Console.WriteLine(s6);
        string s7="";
        Console.WriteLine(string.IsNullOrEmpty(s7)); //to check string is null or empty.
        string s8=" ";
        Console.WriteLine(string.IsNullOrWhiteSpace(s8)); ////to check string is null or contains whitespace.
    }
}