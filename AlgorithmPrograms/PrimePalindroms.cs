using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimePalindroms
    {
        public void Palindrom(int num1, int num2)
        {
            int val, rev, temp, i, num;
            Console.WriteLine("These are Prime Palindrome Numbers:");
            for (num = num1; num <= num2; num++)
            {
                temp = num;
                val = 0;
                rev = 0;
                for (i = 1; i <= temp; i++)
                {
                    if (temp % i == 0)
                        val++;
                }
                if (val == 2)
                {
                    while (temp > 0)
                    {
                        rev = rev * 10 + (temp % 10);
                        temp = temp / 10;
                    }
                    if (rev == num)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
        }
    }
}
