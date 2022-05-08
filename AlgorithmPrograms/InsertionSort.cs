using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class InsertionSort
    {
        public void Sort()
        {
            int[] arr = new int[10] { 63, 9, 85, 12, 99, 34, 40, 15, 100, 2 };
            int n = 10, i, j, val, flag;
            Console.WriteLine("\nInsertion Sort");
            Console.Write("\nArray Before Sorting : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("\nArray After Sorting : ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "  ");
            }
            Console.Write("\n");
        }
    }
}