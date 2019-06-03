using System;

namespace SortBySelection
{

    class Program
    {
        public static int getMin(int[] arr, int start)
        {
            int min = arr[start];
            int minIndex = start;
            for (int i = start+1; i < arr.Length; i++)
                if (arr[i] < min)
                { 
                    min = arr[i];
                    minIndex = i;
                }
            return minIndex;
        }

        public static void printOut(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    public static void Main(string[] args)
        {
            int minIndex;
            int[] tab = { 1, 0, 4, 8, 11, 3, 8, -2, 5, 7 };

            printOut(tab);
            Console.WriteLine();

            for (int i=0; i<tab.Length; i++)
            {
                int tmp = tab[i];
                minIndex = getMin(tab, i);
                if(i != minIndex)
                {
                    tab[i] = tab[minIndex];
                    tab[minIndex] = tmp;
                }
                Console.WriteLine();
                printOut(tab);
            }

            Console.WriteLine("\n---");  
            printOut(tab);
        }
    }

}



