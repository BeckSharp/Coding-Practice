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
            int indexOfSmallest = 0;

            for (int i = 0; i < data.Length; i++)
            {
                indexOfSmallest = i;

                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[indexOfSmallest]) {
                        indexOfSmallest = j;
                    }
                }

                int temp = data[i];
                data[i] = data[indexOfSmallest];
                data[indexOfSmallest] = temp;
            }

            return data;
        }
        
        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }    
    }
}