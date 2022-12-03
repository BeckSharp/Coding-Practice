using System;

namespace QuickSortAlgorithm
{
    internal class QuickSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] data = {7, 8, 2, 3, 5, 1, 0, -10};
            
            data = quickSort(data);

            printResults(data);
        }

        static int[] quickSort(int[] data) 
        {

            return data;
        }
        
        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }    
    }
}