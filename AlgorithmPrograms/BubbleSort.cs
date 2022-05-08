using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubbleSort
    {
        public void Sort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            Console.WriteLine("\nBubble Sort");
          
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted Array :");
            foreach (int p in arr)
                Console.Write(p + "  ");
        }
    }
}