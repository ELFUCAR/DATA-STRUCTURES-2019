/******************************************************************************

LinkList1

*******************************************************************************/
using System;
class LinkList1 {
    
    public static void printAll(int[] array)
    {
        for(int i=0; i<array.Length; i++)
        {
             Console.Write(array[i]+"  ");
      
         }
        
    }
    
  static void Main() {
      
   int[] arr=new int[10];
   arr[0]=1;
   arr[1]=4;
   arr[2]=10;
   
  printAll(arr);
   
  }
}