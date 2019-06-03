
using System;
class HelloWorld {
    
    public static void print(int[] arr){
       for(int i=0; i<arr.Length; i++){
          Console.Write(arr[i] + " ");
      } 
    }
   
    public static int[] insert(int index, int[] arr, int value){
        
        int[] result = new int[arr.Length+1];
        int i=0;
        int temp = arr[index];
        
        //Copy the elements before index
        while(i<index){
            result[i] = arr[i];
            i++;
        }
        
        result[index] = value;
        
        for(int j=index+1; j<arr.Length; j++){
            result[j] = arr[j];
        }
        
        return result;
    }
    
    public static int[] remove(int index, int[] arr){
        
        int[] result = new int[arr.Length-1];
        int i=0;
        
        //Copy the elements before index
        while(i<index){
            result[i] = arr[i];
            i++;
        }
        
        for(int j=index+1; j<arr.Length; j++){
            result[j] = arr[j];
        }
        
        return result;
    }
    
  static void Main() {
      
      
      int [] arr = new int[3];// = {5,6,10};
      
      arr[0] = 5;
      arr[1] = 6;
      arr[2] = 10;
      
      int index = 2;
      int value = 3;
      
      
      Console.WriteLine("Array Before: ");
      print(arr);
      
      Console.WriteLine();
      
      //arr[1] = 3;
      
      Console.WriteLine("Array After insertion: ");
      print(insert(index,arr,value));
      
      Console.WriteLine();
      
      Console.WriteLine("Array After remove: ");
      print(remove(index, arr));

  }
}



