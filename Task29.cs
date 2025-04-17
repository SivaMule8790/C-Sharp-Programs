using System;
class pyramid{
    static void Main(){
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<n;i++){
            for(int j=0;j<n-i-1;j++){
                Console.Write(" ");
            }
            for(char c='A';c<='A'+i;c++){
                Console.Write(c+" ");
            }
            Console.WriteLine();
        }
    }
}

/*Rani needs to create  program that operates a printing machine 
to produce a pyramid-shaped pattern using alphabetic characters. 
This program should take a parameter 'n' to determine the number of rows in 
the pyramid and then navigate the printing machine accordingly to achieve the desired pyramid pattern.

Sample Test Case:

4
    A 
   A B 
  A B C 
 A B C D*/