using System;

namespace BubbleSortAlgorithm
{
    public class BubbleSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] data = {7, 8, 2, 3, 5, 1, 0, -10};
            
            data = bubbleSort(data);

            printResults(data);
        }

        static int[] bubbleSort(int[] data) 
        {
            for (int i = 0; i < (data.Length - 1); i++)
            {
                for (int j = 0; j < (data.Length - i - 1); j++)
                {
                    if (data[j] > data[j + 1]) 
                    {
                        var temp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = temp;
                    }
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