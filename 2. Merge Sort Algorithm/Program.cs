using System;

namespace MergeSortAlgorithm
{
    internal class MergeSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] data = {7, 8, 2, 3, 5, 1, 0, -10};

            data = mergeSort(data);

            printResults(data);
        }

        static int[] mergeSort(int[] data) 
        {
            if (data.Length <= 1) { return data; }

            int midIndex = (data.Length / 2);
            int[] left = new int[midIndex];

            int rightLength = midIndex;
            if (data.Length % 2 == 1) { rightLength++; }
            int[] right = new int[rightLength];

            for (int i = 0; i < midIndex; i++)
            {
                left[i] = data[i];
            }

            int tempIndex = 0;
            for (int i = midIndex; i < data.Length; i++)
            {
                right[tempIndex] = data[i];
                tempIndex++;
            }

            left = mergeSort(left);
            right = mergeSort(right);

            int[] result = merge(left, right);

            return result;
        }

        static int[] merge(int[] left, int[] right)
        {
            int resultLength = left.Length + right.Length;
            int[] result = new int[resultLength];

            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while ((indexLeft < left.Length) || (indexRight < right.Length))
            {
                if ((indexLeft < left.Length) && (indexRight < right.Length))
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++; 
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                }
                else
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                }

                indexResult++;
            }

            return result;
        }

        static void printResults(int[] data) 
        {
            Console.WriteLine("[{0}]", string.Join(", ", data));
        }
    }
}