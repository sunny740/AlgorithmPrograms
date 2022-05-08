using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class AnagramDetection
    {
        public void Detect_Anagram()
        {
            Console.WriteLine("Enter a String 1:");
            string String1 = Console.ReadLine();// abcd
            Console.WriteLine("Enter a String 2:");
            string String2 = Console.ReadLine();// dbca

            char[] charArray1 = String1.ToLower().ToCharArray();
            char[] charArray2 = String2.ToLower().ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            string resultString1 = new string(charArray1);
            string resultString2 = new string(charArray2);
            int result = string.Compare(resultString1, resultString2);
            if (result == 0)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(String1);
                Console.WriteLine(String2);
                Console.WriteLine("Given Strings are Anagrams");
            }
            else
            {
                Console.WriteLine(String1);
                Console.WriteLine(String2);
                Console.WriteLine("Given Strings are not Anagrams");
            }
        }
    }
}
