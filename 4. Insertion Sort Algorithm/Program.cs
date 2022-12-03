using System;

namespace InsertionSortAlgorithm
{
    internal class InsertionSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] data = {7, 8, 2, 3, 5, 1, 0, -10};
            
            data = insertionSort(data);

            printResults(data);
        }

        static int[] insertionSort(int[] data) 
        {

            return data;
        }
        
        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }    
    }
}