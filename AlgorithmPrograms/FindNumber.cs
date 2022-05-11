using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class FindNumber
    {
        public void FNumber(int num)
        {
            //int first = 0, last = 160, mid;
            //while (first != last)
            //{
            //    mid = (first + last) / 2;
            //    Console.WriteLine("Enter 1 if no is b/w" + first + "-" + mid + "\n Enter 2 if No is b/w" + mid + "-" + last);
            //    int c = Convert.ToInt32(Console.ReadLine());
            //    mid = (first + last) / 2;
            //    if (c == 1)
            //        last = mid;
            //    else
            //        first = mid + 1;
            //}
            //return first;
            double powerOfTwo = Math.Pow(2, num);
            double min = 0;
            double max = powerOfTwo - 1;
            while (min <= max)
            {
                double mid_value = (min + max) / 2;
                if (mid_value == num)
                {
                    Console.WriteLine("The number is: " + mid_value);
                    break;
                }
                if (num > mid_value)
                {
                    max = mid_value - 1;
                    Console.WriteLine("The number is: " + max);
                    break;
                }
                else
                {
                    min = mid_value + 1;
                    Console.WriteLine("The number is: " + min);
                    break;
                }
            }
        }
    }
}
