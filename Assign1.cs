using System;
class Assign1
{
  int a=10,b=20;
  static int x=20,y=10;
  void display1()
  {
    // int add1=a+b;
    // int sub1=a-b;
    // int add2=x+y;
    // int sub2=x-y;
    Console.WriteLine("Addition of instance variables: "+ (a+b));
    Console.WriteLine("Subtraction of instance variables: "+ (a-b));
    Console.WriteLine("Addition of static variables: "+ (x+y));
    Console.WriteLine("Subtraction of static variables: "+ (x-y));
  }
  void display2()
  {
    a=100;
    b=200;
    x=200;
    y=100;
    // int add3=a+b;
    // int sub3=a-b;
    // int add4=x+y;
    // int sub4=x-y;
    Console.WriteLine("Reassigning instance variables: ");
    Console.WriteLine(string.Format("a and b values of instance variables is :{0} and {1} ",a,b));
    Console.WriteLine(string.Format("a and b values of static variables is :{0} and {1} ",x,y));
    Console.WriteLine("Addition of Reassigned Instance Variables: "+(a+b));
    Console.WriteLine("Subtraction of Reassigned Instance Variables: "+(a-b));
    Console.WriteLine("Addition of Reassigned static variables: "+ (x+y));
    Console.WriteLine("Subtraction of Reassigned static variables: "+ (x-y));
   }
   static void Main(String[] args){
    Assign1 a1=new Assign1();
    a1.display1();
    a1.display2();
   }
}
/*      Output of the Program

Addition of instance variables: 30
Subtraction of instance variables: -10
Addition of static variables: 30
Subtraction of static variables: 10
Reassigning instance variables:
a and b values of instance variables is :100 and 200
a and b values of static variables is :200 and 100
Addition of Reassigned Instance Variables: 300
Subtraction of Reassigned Instance Variables: -100
Addition of static variables: 300
Subtraction of static variables: 100
*/