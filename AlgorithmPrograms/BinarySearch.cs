using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BinarySearch
    {
        public void binary(string[] inputArray, string key)
        {
            int Start = 0;
            int end = inputArray.Length - 1;
            while (Start <= end)
            {
                int mid = (Start + end) / 2;
                if (key == inputArray[mid])
                {
                    Console.WriteLine("The word is at the middle position {0}", mid);
                    break;
                }
                if (key.CompareTo(inputArray[mid]) > 0)
                {
                    Start = mid - 1;
                    Console.WriteLine("The word is at position {0}", Start);
                    break;
                }
                else
                {
                    end = mid + 1;
                    Console.WriteLine("The word is at position {0}", end);
                    break;
                }
            }
        }
    }
}
