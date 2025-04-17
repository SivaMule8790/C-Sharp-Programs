using System;
class arr{
    static void Main(){
        int[][] a1= new int[3][];
        a1[0]=new int[]{1,2,3,4};
        a1[1]=new int[]{5,3,2,2};
        a1[2]=new int[]{75,433,34};
        for(int i=0;i<a1.Length;i++){
            for(int j=0;j<a1[i].Length;j++){
                Console.Write(a1[i][j]+" ");
            }
            
        }
    }

}
//jagged arrays -> Array of arrays.