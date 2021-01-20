using System;

/**
 * 
 *The easiest of the algorithms of insertion
 *do a binaty search on A[0, i-1] as it is already sorted to have o(n log n) --> binary insertion sort
 */
namespace MITalgorithms
{
    public class InsertionSort
    {
        public InsertionSort()
        {
            int[] numbers = new int[] { 5, 2, 4, 6, 1, 3};
            insert(numbers);
            foreach(int number in numbers)
            {
                System.Console.WriteLine(number);
            }
        }

        public void insert(int[] nums)
        {
            for (int k = 1; k < nums.Length; k++)
            {
                int positionBefore = k - 1;
                while (k>0 && nums[k] < nums[positionBefore])
                {
                    // swap
                    int temp = nums[k];
                    nums[k] = nums[positionBefore];
                    nums[positionBefore] = temp;
                    k--;
                    positionBefore--;
                }

            }
        }

    }
}
