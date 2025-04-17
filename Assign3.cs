using System;
class Assign3
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
    Assign3 a1=new Assign3();
    a1.display1();
    a1.display2();
    Console.WriteLine("Addition of 2 instance  variables: "+ (a1.a+a1.b));
    Console.WriteLine("Subtraction of 2 static variables: "+ (x-y));
   }
}
/*      Output of the Program
    when we are accessing instance variable with the object, the it is possible to add 2 instance varibales  in a static method
    then output is 
    Addition of instance variables: 30
Subtraction of instance variables: -10
Multiplication  of  static variables: 200
Division of  static variables: 2
Addition of 2 instance  variables: 30
Subtraction of 2 static variables: 10

    otherwise adding 2 instance  variables is not possible

*/