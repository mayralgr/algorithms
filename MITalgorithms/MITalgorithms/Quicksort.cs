using System;
namespace MITalgorithms
{
    public class Quicksort
    {
        public Quicksort()
        {
            int[] numbers = new int[] { -555555, 2, 4, 6, 1, 3, 2, 0, 22, 55, 4, -11, -3, 6, 88, 77, 144, 5, 6, 2, 12, 10, 1, 25, 1255, 1478, 12, 36, 25, 98, 7, 4, 14, 52, 525, 8, 9898, 98985522, 45, 4745, 632, 58, 7, 4, 1, 2, 3, 6, 9, 8, 7, 78 };
            QuickSort(numbers, 0, numbers.Length - 1);
            System.Console.WriteLine("Array sorted with quicksort");
            foreach (int number in numbers)
            {
                System.Console.Write(number + " ");
            }
        }

        private void QuickSort(int[] numbers, int start, int end )
        {
            if ( start >= end)
            {
                return;
            }


            // partition
            int pivot = partition(numbers, start, end);

            // recursively sort
            QuickSort(numbers, start, pivot - 1);
            QuickSort(numbers, pivot + 1, end);


        }

        private int partition(int[] numbers, int start, int end)
        {
            // pivot as the last
            int pivot = numbers[end];
            int i = start - 1;
            for(int j = start ; j < end; j++ )
            {
                if ( numbers[j] < pivot)
                {
                    i++;
                    // swap
                    Swap(numbers, i, j);
                }
            }
            // swap
            Swap(numbers, i + 1, pivot);
            return i + 1;
        }

        private void Swap(int[] numbers, int i, int j)
        {
            int temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }

    
}
