using System;
namespace MITalgorithms
{
    public class BinarySearch
    {
        public BinarySearch()
        {
            int[] numbers = new int[] {1, 5, 8, 10, 12, 15, 17 };
            int x = 7;
            int index = search(numbers, x, 0, numbers.Length - 1 );
            if ( index >= 0 )
            {
                System.Console.WriteLine("the value " + x + " is in the " + (index + 1) + " position");
            }
            else
            {
                System.Console.WriteLine("the value " + x + " is not in the array");
            }
            foreach (int number in numbers)
            {
                System.Console.Write(number + " ");
            }
        }

        private int search(int[] array, int x, int start, int end)
        {
            if (start >= end)
            {
                return -1;
            }
            int mid = (start + end) / 2;
            int middle = array[mid];
            if ( x == middle)
            {
                return mid;
            } else if ( x < middle)
            {
                // go left
                return search(array, x, start, mid - 1);
            } else
            {
                // go right
                return search(array, x, mid + 1, end);
            }
        }
    }
}
