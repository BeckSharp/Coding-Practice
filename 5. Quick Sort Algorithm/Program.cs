using System;

namespace QuickSortAlgorithm
{
    internal class QuickSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] data = {7, 8, 2, 3, 5, 1, 0, -10};
            
            data = quickSort(data, 0, (data.Length - 1));

            printResults(data);
        }

        static int[] quickSort(int[] data, int left, int right) 
        {
            if (left < right)
            {
                int pivot = findPivot(data, left, right);

                if (pivot > 1) { return quickSort(data, left, (pivot - 1)); }
                if ((pivot + 1) < right) { return quickSort(data, (pivot + 1), right); }
            }

            return data;
        }
        
        static int findPivot(int[] data, int left, int right)
        {
            int pivot = data[left];

            while (true)
            {
                while (data[left] < pivot) { left++; }
                while (data[right] > pivot) { right--; }

                if (left < right)
                {
                    if (data[left] == data[right]) { return right; }
                    
                    int temp = data[left];
                    data[left] = data[right];
                    data[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }    
    }
}