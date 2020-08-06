using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Algorithms_and_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Sorting Algorithms !");
            int[] examplearray = {
            0,21,40,10,31,5,6,9
            };
            Console.WriteLine("array before Sorting\n");
            foreach(var item in examplearray)
            {
                Console.Write(item + " "); 
            }

            Console.WriteLine();
            DateTime Start = DateTime.Now;
            QuickSort<int>.Sort(examplearray);
            Console.Write("\nTime of Sorting exec.: "); Console.WriteLine(DateTime.Now - Start); 
            Console.WriteLine("array after Sorting\n");
            foreach (var item in examplearray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); Console.WriteLine();
            

            ArrayList tablicaList = new ArrayList(); //System.Collections 
            tablicaList.Add(5);
            tablicaList.AddRange(new int[] { 5, -7, 645 }); // obiekty są typo Object 

        } 
    }

    class SortingAlgorithms 
    {
  

        public static int[] SelectionSort(int[] array) // Big O Notation: O(n^2) because we have two for statements
        {
            int minIndex, minValue;
            minIndex = 0; 
            for(int i=0; i < array.Length; i++)
            {
                bool isSwapped = false;
                minValue = array[i]; 
                for(int j = i; j < array.Length; j++)
                {
                     if(array[j] < minValue)
                     {
                        minIndex = j;
                        minValue = array[j]; 
                        isSwapped = true; 
                     }
                }
                if(isSwapped)
                Swap(ref array[i], ref array[minIndex]); 
            }
            return array; 
        }

        public static int[] InsertionSort(int[] array) // Big O Notation: O(n^2) because we have a for and while statements
        {
            for(int i = 0; i < array.Length; i++)
            {
                int j = i;
                while (j > 0 && array[j].CompareTo(array[j-1]) < 0)
                {
                    Swap(ref array[j], ref array[j - 1]);
                    j--;
                }
            }
            return array; 
        }

        public static int[] BubbleSort(int[] array) // Big O Notation: O(n^2) because we have a for and while statements
        {
            
            for(int i = 0; i < array.Length; i++)
            {
                bool isSwapped = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isSwapped = true;
                        Swap(ref array[j+1], ref array[j]); 
                    }
                    
                }
                if (!isSwapped)
                {
                    break;
                }
            }
            return array; 
        }


        public static void Swap(ref int x, ref int y) 
        {
            int z = x;
            x = y;
            y = z;
            return; 
        }


    }
}
