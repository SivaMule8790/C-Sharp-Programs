using System;
class arr{
    static void Main(){
        int[] a={1,3,4,5,6,7};
        int n=a.Length+1;
        int total=n*(n+1)/2;
        int arrsum=0;
        foreach(int i in a){
            arrsum+=i;
        }
        Console.WriteLine(total-arrsum);
    }
}

/*Given an array nums containing n distinct numbers in the range [1, n], 
return the only number in the range that is missing from the array.
Sample Test Case:
Enter the array elements separated by space: 1 3 4 5
o/p: 2
*/