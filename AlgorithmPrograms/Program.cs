using System;
using AlgorithmPrograms;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome To The Program");
        bool check = true;
        const string path = @"E:\BridgeLabzProject\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\ProgramsData.txt";
        BinarySearch binary = new BinarySearch();
        const string path1 = @"E:\BridgeLabzProject\AlgorithmPrograms\AlgorithmPrograms\AlgorithmPrograms\intvalues.txt";
        
        Console.WriteLine("1. Binary Search\n2. Insertion Sort\n3. Bubble Sort\n4. Merge Sort\n5. Anagram Detection\n6. Prime Numbers\n7. End Of The Process");
        while (check)
        {
            Console.WriteLine("\nTake an Option To Execute");
            int opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    string words = File.ReadAllText(path);
                    string[] input_Array = words.Split(',');
                    Console.WriteLine("Enter The Value");
                    string word = Console.ReadLine();
                    binary.binary(input_Array, word);
                    break;
                
                case 2:
                    Console.WriteLine("Enter a Valid Choice");
                    break;
                case 3:
                    BubbleSort bubble = new BubbleSort();
                    bubble.Sort();
                    break;
                case 4:
                    MergeSort mergesort = new MergeSort();
                    int[] arr2 = { 12, 11, 13, 5, 6, 7 };
                    Console.WriteLine("Given The Values");
                    mergesort.printArray(arr2);
                    mergesort.Sorting(arr2, 0, arr2.Length - 1);
                    Console.WriteLine("\nSorted The Values");
                    mergesort.printArray(arr2);
                    break;
                case 5:
                    AnagramDetection anagram = new AnagramDetection();
                    anagram.Detect_Anagram();
                    break;
                case 6:
                    PrimeNumbers prime = new PrimeNumbers();
                    prime.Check_Prime();
                    break;
                case 7:
                    check = false;
                    break;
                default:
                    Console.WriteLine("Enter Proper Option To Execute");
                    break;
            }
        }
    }
}