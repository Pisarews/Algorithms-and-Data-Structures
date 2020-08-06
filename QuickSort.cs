using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_and_Data_Structures
{
    public class QuickSort<T> where T : IComparable // O(n log n) | O(n^2)
    {
        public static void Sort(T[] array)
        {
            Sort(array, 0, array.Length - 1); 
        }

        private static T[] Sort(T[] array, int lower, int upper)
        {
            if (lower < upper)
            {
                int p = Partition(array, lower, upper);
                Sort(array, lower, p);
                Sort(array, p + 1, upper); 
            }
            return array; 
        }

        private static int Partition(T[] array, int lower, int upper)
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];

            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j-- ; }
                if(i >= j) { break;  }
                Swap(ref array[i], ref array[j]); 
            } while (i <= j); 

            return j; 
        }

        public static void Swap(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
            return;
        }
    }
}
