/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
    
    public static void printAll(int[] array){
        for(int i=0; i<10;i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    
    public static int[] addElement(int pos, int elem, int[] array){
        
        int[] arr2 = new int[10];
        
        for(int i=0; i<array.Length-1; i++){
            if(i < pos){
                arr2[i]=array[i];
            }
            if(i==pos){
                arr2[i]=elem;
            }
            arr2[i+1]=array[i];
        }
        return arr2;
    }
    
    public static int[] deleteElement(int pos, int[] array){
        
        int[] arr2 = new int[10];
        
        for(int i=0; i<array.Length - 1; i++){
            
            arr2[i]=array[i];
            
            if(i==pos){
                arr2[i]=array[i+1];
            }
            if(i > pos){
                arr2[i]=array[i+1];
            }
        }
        return arr2;
    }
    
    static void Main() {
        int[] arr = new int[10];
        arr[0]=5;
        arr[1]=6;
        arr[2]=10;
        
        Console.WriteLine("Original array: ");
        printAll(arr);
    
        Console.WriteLine("Add element 3 in pos. 2: ");
        arr = addElement(2, 3, arr);
        printAll(arr);
    
        Console.WriteLine("DElete element in pos. 3: ");
        arr = deleteElement(3, arr);
        printAll(arr);
  }
}

