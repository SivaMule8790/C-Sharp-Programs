using System;
class spy{
    static void Main(){
        Console.Write("Enter a number: ")
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=0,product=1,rev=0;
        while(num!=0){
            int digit=num%10;
            sum+=digit;
            product*=digit;
            rev=rev*10+digit;
            num=num/10;
        }
        if(sum==product){
            Console.WriteLine("It is spy Number");
            Console.WriteLine("reverse is: "+rev);
        }else{
            Console.WriteLine("It is not spy number");
        }
    }
}
/*Write a program for the below requirements
* calculate sum and product of the given number
* if sum equals to product print it is a spy number and print the given number in reverse order
* if sum and product not equal, print it is not a spy number.
Note : use only while loop
Sample Test Case : 1
123
sum of the given number is: 6
product of the given number is: 6
it is a spy number
Given number in reverse order: 321
Sample Test Case : 2

456
sum of the given number is: 15
product of the given number is: 120
it is not a spy number*/