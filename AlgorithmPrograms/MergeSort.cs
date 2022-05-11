using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class MergeSort
    {
        //public void Merge_sort()
        //{
        //    Console.WriteLine("enter size of array:");
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    int[] array = new int[size];
        //    Console.WriteLine("enter  integer elements of array:");
        //    for (int i = 0; i < size; i++)
        //    {
        //        array[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Sort(array, 0, size - 1);

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write(array[i] + " ");
        //    }

        //}
        //public static int Sort(int[] array, int firstValue, int lastValue)
        //{
        //    if (lastValue > firstValue)
        //    {
        //        int mid = (firstValue + lastValue) / 2;

        //        Sort(array, firstValue, mid);
        //        Sort(array, mid + 1, lastValue);

        //        Merge(array, firstValue, mid, lastValue);
        //    }
        //    return -1;
        //}
        //public static void Merge(int[] array, int firstValue, int mid, int lastvalue)
        //{
        //    int size1 = mid - firstValue + 1;
        //    int size2 = lastvalue - mid;

        //    int[] firstArray = new int[size1];
        //    int[] secondArray = new int[size2];

        //    for (int i = 0; i < size1; i++)
        //    {
        //        firstArray[i] = array[firstValue + i];
        //    }
        //    for (int i = 0; i < size1; i++)
        //    {
        //        secondArray[i] = array[mid + 1 + i];
        //    }

        //    int x = 0, y = 0;
        //    int k = firstValue;
        //    while (x < size1 && y < size2)
        //    {
        //        if (firstArray[x] > secondArray[y])
        //        {
        //            array[k] = secondArray[y];
        //            y++;
        //        }
        //        else
        //        {
        //            array[k] = firstArray[x];
        //            x++;
        //        }
        //        k++;
        //    }
        //    while (x < size1)
        //    {
        //        array[k] = firstArray[x];
        //        x++;
        //        k++;
        //    }
        //    while (y < size2)
        //    {
        //        array[k] = secondArray[y];
        //        y++;
        //        k++;
        //    }
        //}
        public void Merge(int[] arr2, int l, int m, int r)
        {
            // Find sizes of two subarrays to be merged
            int n1 = m - l + 1, n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr2[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr2[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged subarray array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr2[k] = L[i];
                    i++;
                }
                else
                {
                    arr2[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements of L[] if any
            while (i < n1)
            {
                arr2[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements of R[] if any
            while (j < n2)
            {
                arr2[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that sorts arr[l..r] using merge()
        public void Sorting(int[] arr2, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point
                int m = l + (r - l) / 2;

                // Sort first and second Values
                Sorting(arr2, l, m);
                Sorting(arr2, m + 1, r);

                // Merge the sorted Values
                Merge(arr2, l, m, r);
            }
        }

        // A utility function to print array of size n */
        public void printArray(int[] arr2)
        {
            int n = arr2.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr2[i] + " ");
            Console.WriteLine();
        }
    }
}
