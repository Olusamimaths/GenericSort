using System;


namespace GenericSort
{
    /// <summary>
    /// InsertionSort Class
    /// Contains method for sorting an array of elements of type T, 
    /// where T must implement 
    /// <list type="bullet">
    /// <item>
    /// <term>Sort</term>
    /// <description>Sort Operation</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <typeparam name="T">A generic Type that must implement IComparable</typeparam>
    public class InsertionSort<T> where T : IComparable
    {
        /// <summary>
        /// Takes in an unsorted array of type T elements and sorts the array in place
        /// </summary>
        /// <param name="arr">An array of type T elements</param>
        public static void Sort(T[] arr) 
        { 
            // start a loop from the second element in the array
         for(int j = 1; j < arr.Length; j++) {
             // pick a current element from the unsorted sub-array from A[j...n]
             T key = arr[j];
             int i = j - 1;
             // find a position from the current element
             while (i >= 0 && (arr[i].CompareTo(key) >= 1)) {
                 arr[i+1] = arr[i];
                 i = i -1;
             }
             // insert the element at the right position
             arr[i + 1] = key;
          }
        }
    }
}
