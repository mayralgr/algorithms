using System;

/***
 * 
 * Divide and conquer algoritm
 * Recurrence solving
 ***/
namespace MITalgorithms
{
    public class MergeSort
    {
        public MergeSort()
        {
            // -555555, 2, 4, 6, 1, 3,2,0,22,55,4,-11,-3,6,88,77,144,5,6,2,12,10,1,25,1255,1478,12,36,25,98,7,4,14,52,525,8,9898,98985522,45,4745,632,58,7,4,1,2,3,6,9,8,7,78
            int[] numbers = new int[] { 5, 2, 4, 7, 1, 3, 6 };
            mergeSort( numbers );
            System.Console.WriteLine("Array sorted with merge sort");
            foreach (int number in numbers)
            {
                System.Console.Write(number + " ");
            }
        }

        public void mergeSort(int[] nums)
        {
            int length = nums.Length;
            if ( length == 1 )
            {
                return;
            }
            // for division
            int mid = ( length ) / 2;

            // auxilary arrays
            int[] leftArray = SubArray(nums,0,mid);
            int[] rightArray = SubArray(nums, mid, (length-mid));

            mergeSort(leftArray);
            mergeSort(rightArray);
            // merge them
            merge(nums,leftArray,rightArray);
        }

        private void merge(int[] array, int[] leftArray, int[] rightArray)
        {
            int positionRight = 0, positionLeft = 0, i = 0;
            while(positionLeft < leftArray.Length && positionRight< rightArray.Length)
            {
                if (leftArray[positionLeft] > rightArray[positionRight])
                {
                    array[i] = rightArray[positionRight];
                    positionRight++;
                    i++;
                } else
                {
                    array[i] = leftArray[positionLeft];
                    positionLeft++;
                    i++;
                }
            }
            // if there are missing numbers in the left that are greater than all of the rigth
            while(positionLeft < leftArray.Length)
            {
                array[i] = leftArray[positionLeft];
                positionLeft++;
                i++;
            }

            // if there are missing numbers in the right that are greater than all of the left
            while (positionRight < rightArray.Length)
            {

                array[i] = rightArray[positionRight];
                positionRight++;
                i++;
            }
        }

        public int[] SubArray(int[] data, int index, int length)
        {
            int[] result = new int[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }
    }
}
