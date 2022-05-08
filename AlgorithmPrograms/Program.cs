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
        
        Console.WriteLine("1. Binary Search\n2. Insertion Sort\n3. bubble Sort\n");
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
                default: break;
            }
        }
    }
}