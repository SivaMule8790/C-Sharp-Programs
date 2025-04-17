using System;
class sm{
    static void Main(){
        int[] num={1,2,3,4,2,5,1,2};
        Console.WriteLine(string.Join(",",num));
        Array.Clear(num,2,3);    //2 indicates starting index and 3 indicates length ie., no.of elements to clear.
        Console.WriteLine(string.Join(",",num));
        int[] num1=new int[5];
        Array.Copy(num,0,num1,0,5);  //Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length);
        Console.WriteLine(string.Join(",",num1));
        int[] num2=new int[10];
        num.CopyTo(num2,2); //sourceArray.CopyTo(destinationArray, start index);
        Console.WriteLine(string.Join(",",num2));
        int a1=Array.IndexOf(num,3);  //int index = Array.IndexOf(array, value); if value not present returns -1.
        Console.WriteLine(a1);
        int[] num3={1,243,3,44,5,62,5};   
        int a2=Array.LastIndexOf(num3,5); //int lastIndex = Array.LastIndexOf(array, value);  returns last repeted value index
        Console.WriteLine(a2);
        Array.Sort(num3);                   //sort
        Console.WriteLine(string.Join(",",num3));
        Array.Reverse(num3);                //reverse
        Console.WriteLine(string.Join(",",num3));
        Array.Resize(ref num3,10);           //Array.Resize(ref array, newSize); ref used to assign address
        Console.WriteLine(string.Join(",",num3));
        int[] num4={5,3,4,2,32,4,2,4,2,2,444,3,32,33,3,4,3};
        int a3=Array.Find(num4,n=>n >3);           //Fisrt occurence only
        Console.WriteLine(a3); 
        int[] num5=Array.FindAll(num4,n=>n >3);     // stores all elemnts > than value in array 
        Console.WriteLine(string.Join(",",num5));
        Array.ForEach(num5,n=>Console.Write(n*2+" ")); //Array.ForEach(array, action);  //// Prints each element multiplied by 2
        Console.WriteLine();
        Console.WriteLine(Array.Exists(num5,n => n ==5)); //
        Console.WriteLine(Array.TrueForAll(num5,n => n >0));
        int[] num6=(int[]) num5.Clone();
        Console.WriteLine(string.Join(",",num6));
        int[] num7=new int[10];
       // Array.Fill(num7,5);        // only for latest version
       //Array.FillAll(num7,5);
        //Console.WriteLine(string.Join(",",num7));
    }
}