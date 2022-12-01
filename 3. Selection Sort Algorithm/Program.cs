using System;

namespace SelectionSortAlgorithm // Note: actual namespace depends on the project name.
{
    internal class SelectionSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] data = {7, 8, 2, 3, 5, 1, 0, -10};
            
            data = selectionSort(data);

            printResults(data);
        }

        static int[] selectionSort(int[] data) 
        {

            return data;
        }
        
        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }    
    }
}