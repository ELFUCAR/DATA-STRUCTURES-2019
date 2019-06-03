/******************************************************************************

LinkList2-arrays

*******************************************************************************/
using System;
class LinkList1 {
    
    public static void printAll(int[] array)
    {
        for(int i=0; i<array.Length; i++)
        {
             Console.Write(array[i]+"  ");
               
         }
         Console.WriteLine("\n-----");
    }
    
  static void Main() {
      
   int[] arr=new int[10];
     int[] temp=new int[10];
   
   arr[0]=1;
   arr[1]=4;
   arr[2]=10;
   printAll(arr);
 
 for(int i=0;i<arr.Length;i++)
 {
     
       arr[i]=temp[i];
 }
  
   
    // we want to insert e.g. 100 at the index 2.
   int indx=2;
   
   for(int i=0;i<indx;i++)
   {
       
       arr[i]=temp[i];
      
   }
   
        arr[indx]=100;
    
     for(int i=indx; i<temp.Length-1;i++)
   {
       
       arr[i+1]=temp[i];
      
   }
    
    
  printAll(arr);
   
  }
}
