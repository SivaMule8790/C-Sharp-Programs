
using System;
class Assign2
{
  int a=10,b=20;
  static int x=20,y=10;
  void display1()
  {
 
    Console.WriteLine("Addition of instance variables: "+ (a+b));
    Console.WriteLine("Subtraction of instance variables: "+ (a-b));
    
  }
  void display2()
  {

    
    Console.WriteLine("Multiplication  of  static variables: "+ (x*y));
    Console.WriteLine("Division of  static variables: "+ (x/y));
   }
   static void Main(String[] args){
    Assign2 a1=new Assign2();
    a1.display1();
    a1.display2();
    Console.WriteLine("Addition of 1 instance and 1 static variables: "+ (a1.a+x));
    Console.WriteLine("Subtraction of 1 instance and 1 static variables: "+ (a1.b-y));
   }
}
/*      Output of the Program
    when we are accessing instance variable with the object, the it is possible to add 1 static and 1 instance varibales in a static method
    then output is 
    Addition of instance variables: 30
    Subtraction of instance variables: -10
    Multiplication  of  static variables: 200
    Division of  static variables: 2
    Addition of 1 instance and 1 static variables: 30
    Subtraction of 1 instance and 1 static variables: 10

    otherwise adding 1 instance and 1 static variables is not possible

*/