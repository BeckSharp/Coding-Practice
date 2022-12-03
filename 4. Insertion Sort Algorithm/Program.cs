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
            int index;
            for (int i = 0; i < (data.Length - 1); i++)
            {
                index = i;

                while ((index >= 0) && (data[index + 1] < data[index]))
                {
                    int temp = data[index];
                    data[index] = data[index + 1];
                    data[index + 1] = temp;

                    index--;
                }
            }

            return data;
        }
        
        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }    
    }
}